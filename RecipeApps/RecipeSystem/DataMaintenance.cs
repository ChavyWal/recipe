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

        public static void Save(DataTable dtcookbook)
        {
            if (dtcookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call Cookbook save method because there are no rows in table");
            }
            DataRow r = dtcookbook.Rows[0];
            SQLUtility.SaveDateRow(r, "CookbookUpdate");
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

        public static void CookbookRecipeDelete(int cookbookrecipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            SQLUtility.Setparamvalue(cmd, "@Cookbookrecipeid", cookbookrecipeid);
           SQLUtility.ExecuteSQL(cmd);
        }

        public static void CookbookRecipeSave(DataTable dt, int cookbookid)
        {
            foreach(DataRow dr in dt.Select("", "", DataViewRowState.Added))
            {
                dr["Cookbookid"] = cookbookid;
            }
            SQLUtility.SaveDataTable(dt, "CookbookRecipeUpdate");
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

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.Setparamvalue(cmd, $"@{tablename}Id", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.Setparamvalue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.Setparamvalue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }
    }
}
