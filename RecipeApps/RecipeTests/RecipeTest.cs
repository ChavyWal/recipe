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
            dbManager.SetConnectionString("Server=tcp:dev-cw.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;User ID=cwadmin;Password=Chw280qc;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeID();
            Assume.That(recipeid > 0, "no recipe in DB, can't test");

            TestContext.WriteLine("existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);

            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];
            Assert.IsTrue(loadedid == recipeid, loadedid + " != " + recipeid);
            TestContext.WriteLine("Loaded recipe ( " + loadedid + " )" + recipeid);
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.RecipeID, r.RecipeName, c.CuisineType, r.Cuisinetypeid, r.usersid, r.Calories, r.DateDraft, r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture, u.UserName from recipe r join CuisineType c on c.CuisineTypeID = r.CuisineTypeID join users u on u.UsersID = r.UsersID left join RecipeDirection rd on r.RecipeID = rd.recipeid left join recipeingredient ri on r.recipeid = ri.recipeid left join mealcourserecipe mr on r.recipeid = mr.recipeid  left join cookbookRecipe cr on r.recipeid = cr.recipeid where rd.recipedirectionid is null and ri.recipeingredientid is null and mr.mealcourserecipeid is null and cr.cookbookrecipeid is null");
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
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe r where r.recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + "Exists in DB");
            TestContext.WriteLine("Record with recipeid " + recipeid + "deos not exist in the DB" );
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
            datedraft = "2023 -09-09";
            cuisinetypeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            usersid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 usersid from users");
            calories = calories + 5;
            recipename = recipename + calories.ToString();
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

            r["RecipeName"] = recipe;
            r["calories"] = 123;
            r["cuisinetypeid"] = cuisinetypeid;
            r["DateDraft"] = "2023-03-03";
            r["usersid"] = usersid;

            Recipe.save(dt);
            int newid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe where recipename = '" + recipe + "'");
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
    }
}