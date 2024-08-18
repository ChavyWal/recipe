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
    }
}
