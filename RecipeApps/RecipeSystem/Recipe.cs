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
            SQLUtility.Setparamvalue(cmd,"@recipename" ,recipename);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.Setparamvalue(cmd, "@recipeid", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineTypelist()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineTypeGet");
           SQLUtility.Setparamvalue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserslist()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            SQLUtility.Setparamvalue(cmd, "@All", 1);
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
                string datedraft = r["DateDraft"].ToString();
                if (datedraft == "")
                {
                    r["DateDraft"] = DateTime.Now.ToString("yyyy, MMMM, dd");
                }
                statetement = "insert recipe(RecipeName, calories, CuisineTypeID, DateDraft, UsersID)";
                statetement += $"select '{r["RecipeName"]}', '{r["Calories"]}', '{r["CuisineTypeid"]}', '{r["DateDraft"]}', '{r["usersID"]}'";
            }
            SQLUtility.ExecuteSQL(statetement);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["recipeid"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.Setparamvalue(cmd, "@recipeid", id);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
