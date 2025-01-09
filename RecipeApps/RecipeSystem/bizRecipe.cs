using CPUFramework;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.Common;

namespace RecipeSystem
{
    public class bizRecipe : bizObject<bizRecipe>
    {
        public bizRecipe()
        {

        }

        private int _recipeid;
        private int _usersid;
        private string _username = "";
        private int _cuisinetypeid;
        private string _recipename = "";
        private int _vegan ;
        private int _calories;
        private string _currentstatus;
        private int _numingredients;
        private DateTime _datedraft;
        private DateTime? _datepublished;
        private DateTime? _datearchived;

        public List<bizRecipe> Search(string recipenameval)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(this.GetSprocName);
            SQLUtility.Setparamvalue(cmd, "RecipeName", recipenameval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UsersId
        {
            get { return _usersid; }
            set
            {
                if (_usersid != value)
                {
                    _usersid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string UserName
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisinetypeId
        {
            get { return _cuisinetypeid; }
            set
            {
                if (_cuisinetypeid != value)
                {
                    _cuisinetypeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int NumIngredients
        {
            get { return _numingredients; }
            set
            {
                if (_numingredients != value)
                {
                    _numingredients = value;
                    InvokePropertyChanged();
                }
            }
        }


        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CurrentStatus
        {
            get { return _currentstatus; }
            set
            {
                if (_currentstatus != value)
                {
                    _currentstatus = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Calories
        {
            get { return _calories; }
            set
            {
                if (_calories != value)
                {
                    _calories = value;
                    InvokePropertyChanged();
                }
            }
        }

        

        public DateTime DateDraft
        {
            get { return _datedraft; }
            set
            {
                if (_datedraft != value)
                {
                    _datedraft = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime? DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int Vegan
        {
            get { return _vegan; }
            set
            {

                if (_vegan != value)
                {
                    _vegan = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
