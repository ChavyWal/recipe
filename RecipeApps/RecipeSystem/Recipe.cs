﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        
        public static DataTable Load(int recipeid)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.Setparamvalue(cmd, "@recipeid", recipeid);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
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

        public static DataTable SearchRecipe(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.Setparamvalue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.Setparamvalue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineTypelist(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineTypeGet");
           SQLUtility.Setparamvalue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.Setparamvalue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetIngredientTable(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientGet");
            SQLUtility.Setparamvalue(cmd, "@Recipeid", recipeid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetIngredients()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("IngredientGet");
            SQLUtility.Setparamvalue(cmd, "@includeBlank", 1);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetStepsTable(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("StepsGet");
            SQLUtility.Setparamvalue(cmd, "@Recipeid", recipeid);
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable GetUserslist(bool includeblank = false)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UsersGet");
            SQLUtility.Setparamvalue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.Setparamvalue(cmd, "@IncludeBlank", includeblank);
            }
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable RecipeMealandCookbookCount()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeMealandCookbookCount");
            return SQLUtility.GetDataTable(cmd);
        }

        public static DataTable MealGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealGet");
            return SQLUtility.GetDataTable(cmd);
        }

        public static void DeleteRecipeIngredient(int recipeingredientid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientDelete");
            SQLUtility.Setparamvalue(cmd, "@Recipeingredientid", recipeingredientid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void RecipeIngredientSave(DataTable dt,int recipeid)
        {
            foreach(DataRow dr in dt.Select("","", DataViewRowState.Added))
            {
                dr["Recipeid"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeIngredientUpdate");
        }

        public static void DeleteRecipeSteps(int recipestepsid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeStepsDelete");
            SQLUtility.Setparamvalue(cmd, "@RecipeDirectionid", recipestepsid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void RecipeStepsSave(DataTable dt, int recipeid)
        {
            foreach (DataRow dr in dt.Select("", "", DataViewRowState.Added))
            {
                dr["Recipeid"] = recipeid;
            }
            SQLUtility.SaveDataTable(dt, "RecipeStepsUpdate");
        }

        public static int CloneRecipe(int recipeid)
        {
            int i;
            SqlCommand cmd = SQLUtility.GetSqlCommand("CloneRecipe");
            SQLUtility.Setparamvalue(cmd, "@recipeid", recipeid);
            SQLUtility.ExecuteSQL(cmd);
            i = (int)cmd.Parameters["@Newrecipeid"].Value;
            return i;
        }

        
    }
}
