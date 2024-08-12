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
        public static DataTable SearchRecipe()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.Setparamvalue(cmd,"@recipename" ,"%");
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable CookbookGet()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.Setparamvalue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
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

        public static DataTable RecipeMealandCookbookCount()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeMealandCookbookCount");
            return SQLUtility.GetDataTable(cmd);
        }

        public static void save(DataTable dtrecipe)
        {
            if (dtrecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call recipe save method because there are no rows in table");
            }
            DataRow r = dtrecipe.Rows[0];
            SQLUtility.SaveDateRow(r, "RecipeUpdate");
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
