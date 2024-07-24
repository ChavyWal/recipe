using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    //SQLUtility.ConnectionString = ;
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipename)
        {
            string sql = "Select r.Recipename, r.Recipeid from recipe r join users u on r.usersid = u.usersid where r.Recipename like '%" + recipename + "%' order by recipeid";
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable Load(int recipeid)
        {
            string sql = "select r.RecipeID, r.RecipeName, c.CuisineType, r.Cuisinetypeid, r.usersid, r.Calories, r.DateDraft, r.DatePublished, r.DateArchived, r.CurrentStatus, r.RecipePicture, u.UserName from recipe r join CuisineType c on c.CuisineTypeID = r.CuisineTypeID join users u on u.UsersID = r.UsersID where r.recipeid = " + recipeid.ToString();
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetCuisineTypelist()
        {
            return SQLUtility.GetDataTable("select c.CuisineTypeid, c.CuisineType from CuisineType c");
        }

        public static DataTable GetUserslist()
        {
            return SQLUtility.GetDataTable("Select usersID, username from users u");
        }

        public static void save(DataTable dtrecipe)
        {
            DataRow r = dtrecipe.Rows[0];
            int id = (int)r["recipeid"];
            string statetement = "";
            if (id > 0)
            {
                statetement = string.Join(Environment.NewLine, $"update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = '{r["Calories"]}',",
                    $"CuisineTypeid = '{r["CuisineTypeid"]}',",
                    $"DateDraft = '{r["DateDraft"]}',",
                    $"UsersId = '{r["usersID"]}'",
                    $"where recipeid = '{r["recipeid"]}'"
                    );
            }
            else
            {
                
                statetement = "insert recipe(RecipeName, calories, CuisineTypeID, DateDraft, UsersID)";
                statetement += $"select '{r["RecipeName"]}', '{r["Calories"]}', '{r["CuisineTypeid"]}', '{r["DateDraft"]}', '{r["usersID"]}'";
            }
            SQLUtility.ExecuteSQL(statetement);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["recipeid"];
            string sql = "delete recipe where recipeid = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}
