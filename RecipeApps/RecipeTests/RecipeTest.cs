using RecipeSystem;
using CPUFramework;
using System.Data;

namespace RecipeTests
{
    public class RecipeTests
    {
        [SetUp]
        public void Setup()
        {
            dbManager.SetConnectionString("Server=tcp:dev-cw.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", true, "cwadmin", "Chw280qc");
        }

        //[Test]
        //public void SearchRecipe()
        //{
        //    string criteria = "c";
        //    int num = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe where recipename like '%" + criteria + "%'");
        //    Assume.That(num > 0, "can't run test, no recipes  macht your search");
        //    TestContext.WriteLine(num + " recipes that match " + criteria);
        //    TestContext.WriteLine("want to ensure that recipe search returns " + num + " rows");

        //    DataTable dt = Recipe.SearchRecipe(criteria);
        //    int results = dt.Rows.Count;
        //    Assert.IsTrue(results == num, "results of recipe search deos not match number of recipes, " + results + " <> " + num);
        //    TestContext.WriteLine("number of rows returned by recipe search is " + results);
        //}

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeID();
            Assume.That(recipeid > 0, "no recipe in DB, can't test");
            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            int loadedid = recipe.RecipeId;
            Assert.IsTrue(loadedid == recipeid, loadedid + " != " + recipeid);
            TestContext.WriteLine("Loaded recipe ( " + loadedid + " )" + recipeid);
        }

        [Test]
        public void DeleteRecipe()
        {
            InsertnewRecipe();
            DataTable dt = SQLUtility.GetDataTable(@"select top 1 
                r.RecipeID, r.RecipeName, c.CuisineType, 
                r.Cuisinetypeid, r.usersid, r.Calories, 
                r.DateDraft, r.DatePublished, r.DateArchived, 
                r.CurrentStatus, r.RecipePicture, u.UserName 
                from recipe r 
                join CuisineType c 
                on c.CuisineTypeID = r.CuisineTypeID 
                join users u on u.UsersID = r.UsersID 
                left join RecipeDirection rd 
                on r.RecipeID = rd.recipeid 
                left join recipeingredient ri 
                on r.recipeid = ri.recipeid 
                left join mealcourserecipe mr 
                on r.recipeid = mr.recipeid  
                left join cookbookRecipe cr 
                on r.recipeid = cr.recipeid 
                where rd.recipedirectionid is null 
                and ri.recipeingredientid is null 
                and mr.mealcourserecipeid is null 
                and cr.cookbookrecipeid is null
                and (r.CurrentStatus <> 'Published' or (r.CurrentStatus = 'Archived'
                and DateDiff(DAY, r.DateArchived, CURRENT_TIMESTAMP) > 30))
                ");
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "no recipes in the DB, can't run test");
            TestContext.WriteLine("existing recipe without child tables with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app can delete " + recipeid);
            bizRecipe recipe = new();
            recipe.Load(recipeid);
            recipe.Delete();
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe r where r.recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "Exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + "deos not exist in the DB" );
        }

        [Test]
        public void CannotDeleteRecipewitharchivedlessthanthirtydays()
        {
            DataTable dt = SQLUtility.GetDataTable(@"select top 1 
                r.RecipeID, r.RecipeName, c.CuisineType, 
                r.Cuisinetypeid, r.usersid, r.Calories, 
                r.DateDraft, r.DatePublished, r.DateArchived,
                r.CurrentStatus, r.RecipePicture, u.UserName 
                from recipe r join CuisineType c 
                on c.CuisineTypeID = r.CuisineTypeID 
                join users u on u.UsersID = r.UsersID 
                join RecipeDirection rd 
                on r.RecipeID = rd.recipeid 
                join recipeingredient ri 
                on r.recipeid = ri.recipeid 
                left join mealcourserecipe mr 
                on r.recipeid = mr.recipeid  
                left join cookbookRecipe cr 
                on r.recipeid = cr.recipeid 
                where (r.CurrentStatus = 'Published' or (r.CurrentStatus = 'Archived'
                and DateDiff(DAY, r.DateArchived, CURRENT_TIMESTAMP) <= 30))
                and cr.cookbookrecipeid is null"
                );
            int recipeid = 0;
            string recipedesc = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipedesc = dt.Rows[0]["recipename"].ToString();
            }
            
            TestContext.WriteLine("existing recipe with child tables with id = " + recipeid + " " + recipedesc);
            TestContext.WriteLine("ensure that app cannot delete " + recipeid);

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipe()
        {
            int id = GetExistingRecipeID();
            Assume.That(id > 0, "no recipe in db, can't test");
            

            DataTable dtt = SQLUtility.GetDataTable("select recipename, calories, cuisinetypeid, usersid, datedraft  from recipe where recipeid = " + id);
            int calories = (int)dtt.Rows[0]["calories"];
            string recipename = dtt.Rows[0]["Recipename"].ToString();
            string datedraft = dtt.Rows[0]["datedraft"].ToString();
            int cuisinetypeid = (int)dtt.Rows[0]["cuisinetypeid"];
            int usersid = (int)dtt.Rows[0]["usersid"];
            TestContext.WriteLine(" for recipeid " + id + " calories is " + calories + " recipename is " + recipename + " DateDraft is " + datedraft + " cuisinetypeid is " + cuisinetypeid + " usersid is " + usersid);
            datedraft = "1900 -09-09";
            cuisinetypeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            calories = calories + 5;
            recipename =  calories.ToString();
            DataTable dt = Recipe.Load(id);
            TestContext.WriteLine("change calories to " + calories);
            dt.Rows[0]["calories"] = calories;
            TestContext.WriteLine("change recipename to " + recipename);
            dt.Rows[0]["recipename"] = recipename;
            TestContext.WriteLine("change datedraft to " + datedraft);
            dt.Rows[0]["datedraft"] = datedraft;
            TestContext.WriteLine("change cuisinetypeid to " + cuisinetypeid);
            dt.Rows[0]["cuisinetypeid"] = cuisinetypeid;
            TestContext.WriteLine("change usersid to " + usersid);
            dt.Rows[0]["usersid"] = usersid;

            Recipe.save(dt);

            DataTable modifiedtable = SQLUtility.GetDataTable("select recipename, calories, cuisinetypeid, usersid, datedraft  from recipe where recipeid = " + id);
             string mrecipename = modifiedtable.Rows[0]["recipename"].ToString() ;
            int mcalories = (int)modifiedtable.Rows[0]["calories"];
            string mdatedraft = modifiedtable.Rows[0]["Datedraft"].ToString();
            int mcuisinetypeid = (int)modifiedtable.Rows[0]["cuisinetypeid"];
            int musersid = (int)modifiedtable.Rows[0]["usersid"];

            Assert.IsTrue(mrecipename == dt.Rows[0]["Recipename"].ToString(), " recipename not modified");
            Assert.IsTrue(mcalories == (int)dt.Rows[0]["calories"], " calories not modified");
            Assert.IsTrue(mdatedraft == dt.Rows[0]["datedraft"].ToString(), " datedraft not modified");
            Assert.IsTrue(mcuisinetypeid == (int)dt.Rows[0]["cuisinetypeid"], " cuisinetypeid not modified");
            Assert.IsTrue(musersid == (int)dt.Rows[0]["usersid"], " usersid not modified");

            TestContext.WriteLine(" For recipe (" + id + ") calories: " + mcalories+ " recipename: " + mrecipename + " DateDraft: " + mdatedraft + " Cuisinetpeid: " + mcuisinetypeid + " usersid: " + musersid);
        }

        [Test]
        public void ChangeExistingRecipeToInvalidDateDraft()
        {
            int recipeid = GetExistingRecipeID();
            
            Assume.That(recipeid > 0, "no recipes in the DataBase, Can't run.");
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["datedraft"] = DateTime.Today.AddYears(10);
            Exception ex = Assert.Throws<Exception>(() => Recipe.save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void ChangeExistingRecipeToInvalidName()
        {
            int recipeid = GetExistingRecipeID();

            Assume.That(recipeid > 0, "no recipes in the DataBase, Can't run.");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <> " + recipeid );
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["Recipename"] = recipename;
            Exception ex = Assert.Throws<Exception>(() => Recipe.save(dt));
            TestContext.WriteLine(ex.Message);
        }


        [Test]
        public void InsertnewRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1, "there are no rows");
            int cuisinetypeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            int usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            DateTime dtt = DateTime.Now;
            string recipe = "Test" + dtt.ToString();
            Assume.That(cuisinetypeid > 0, "there are no cuisinetypes");
            Assume.That( usersid > 0, "there are no users");

            TestContext.WriteLine("insert recipe with name " + recipe);
            bizRecipe re = new();
            re.RecipeName = recipe;
            re.Calories = 666;
            re.CuisinetypeId = cuisinetypeid;
            re.DateDraft = DateTime.Now.AddDays(-333);
            //re.DateArchived = dtt;
            re.UsersId = usersid;
            
            re.Save();
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe where recipename = '" + recipe + "'");
            int pkid = re.RecipeId;
            Assert.IsTrue(newid > 0, "recipe with name " + recipe + "is not found in the db");
           TestContext.WriteLine("recipe with " + recipe + " found in db with pk value = " + newid);

        }

        [Test]
        public void GetListCuisineType()
        {
            int cuisinetypecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from cuisinetype");
            Assume.That(cuisinetypecount > 0, "no cuisinetypes in db, can't test");

            TestContext.WriteLine("Num of CuisineTypes in DB = " + cuisinetypecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + cuisinetypecount);

            DataTable dt = Recipe.GetCuisineTypelist();

            Assert.IsTrue(dt.Rows.Count == cuisinetypecount, "num rows returned by app (" + dt.Rows.Count + ") <>" + cuisinetypecount);
            TestContext.WriteLine("Number of rows in Cusinetype returned by app = " + dt.Rows.Count);
        }


        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void GetListRecipies(bool includeblank)
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            if (includeblank == true) { recipecount = recipecount + 1; }
            Assume.That(recipecount > 0, "no recipies in db, can't test");

            TestContext.WriteLine("Num of recipes in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe recipe = new();
            var lst = recipe.GetList(includeblank );

            Assert.IsTrue(lst.Count == recipecount, "num rows returned by app (" + lst.Count + ") <>" + recipecount);
            TestContext.WriteLine("Number of rows in recipie returned by app = " + lst.Count);
        }

        [Test]
        [TestCase(true)]
        [TestCase(false)]
        public void GetListIngredient( bool includeblank)
        {
            int ingredientcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from Ingredient");
            if(includeblank == true) { ingredientcount = ingredientcount + 1; }
            Assume.That(ingredientcount > 0, "no ingredients in db, can't test");

            TestContext.WriteLine("Num of ingredients in DB = " + ingredientcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredientcount);
            bizIngredient ing = new();
            var lst = ing.GetList(includeblank);

            Assert.IsTrue(lst.Count == ingredientcount, "num rows returned by app (" + lst.Count + ") <>" + ingredientcount);
            TestContext.WriteLine("Number of rows in ingredient returned by app = " + lst.Count);
        }

        [Test]
        public void SearchRecipe()
        {
            string recipename = "h";
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from recipe where recipename like '%{recipename}%'");
            TestContext.WriteLine("Num of search results in DB = " + recipecount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + recipecount);
            bizRecipe r = new();
            List<bizRecipe> lst = r.Search(recipename);
            Assert.IsTrue(lst.Count == recipecount, "num rows returned by search (" + lst.Count + ") <> " + recipecount);
            TestContext.WriteLine("Number of rows in search results return by app = " + lst.Count);
        }

        [Test]
        public void SearchIngredient()
        {
            string ingredientname = "h";
            int ingredinetcount = SQLUtility.GetFirstColumnFirstRowValue($"select total = count(*) from ingredient where ingredientname like '%{ingredientname}%'");
            TestContext.WriteLine("Num of search results in DB = " + ingredinetcount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + ingredinetcount);
            bizIngredient r = new();
            List<bizIngredient> lst = r.Search(ingredientname);
            Assert.IsTrue(lst.Count == ingredinetcount, "num rows returned by search (" + lst.Count + ") <> " + ingredinetcount);
            TestContext.WriteLine("Number of rows in search results return by app = " + lst.Count);
        }

        [Test]
        public void GetListUsers()
        {
            int userscount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from users");
            Assume.That(userscount > 0, "no users in db, can't test");

            TestContext.WriteLine("Num of users in DB = " + userscount);
            TestContext.WriteLine("Ensure that num of rows return by app matches " + userscount);

            DataTable dt = Recipe.GetUserslist();

            Assert.IsTrue(dt.Rows.Count == userscount, "num rows returned by app (" + dt.Rows.Count + ") <>" + userscount);
            TestContext.WriteLine("Number of rows in users returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeID()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeid from recipe");
        }

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string n = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    n = dt.Rows[0][0].ToString();
                }
            }
            return n;
        }
    }
}