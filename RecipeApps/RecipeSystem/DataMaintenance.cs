using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class DataMaintenance
    {

        public static DataTable CookbookGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.Setparamvalue(cmd, "@All", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable Load(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookGet");
            SQLUtility.Setparamvalue(cmd, "@Cookbookid", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable CookbookRecipeGet(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeGet");
            SQLUtility.Setparamvalue(cmd, "@Cookbookid", cookbookid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable MeasurmentsGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MeasurmentsGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable CoursesGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CoursesGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static void CookbookDelete(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.Setparamvalue(cmd, "@Cookbookid", cookbookid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void AutoCreateCookbook(int usersid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.Setparamvalue(cmd, "@usersid", usersid);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
