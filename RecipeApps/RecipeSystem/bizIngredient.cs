﻿using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizIngredient: bizObject<bizIngredient>
    {
        private int _ingredientid;
        private string _ingredientname = "";

        public List<bizIngredient> Search(string ingredientnameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.Setparamvalue(cmd, "IngredientName", ingredientnameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int IngredientId
        {
            get { return _ingredientid; }
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientName
        {
            get { return _ingredientname; }
            set
            {
                if (_ingredientname != value)
                {
                    _ingredientname = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}