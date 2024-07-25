using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@recipename"].Value = recipename;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@recipeid"].Value = recipeid;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineTypelist()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineTypeGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserslist()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
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
