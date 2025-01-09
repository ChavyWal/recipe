using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;
using System.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class bizCookbook : bizObject<bizCookbook>
    {
        public bizCookbook()
        {

        }

        private int _cookbookid;
        private int _usersid;
        private string _username = "";
        private string _cookbookname = "";
        private decimal _cookbookprice;
        private DateTime _cookbookdate;
        private int _cookbookskillnumber;
        private string _cookbookskill;
        private bool _active = true;

        public int CookbookId
        {
            get { return _cookbookid; }
            set
            {
                if (_cookbookid != value)
                {
                    _cookbookid = value;
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

        public string CookbookName
        {
            get { return _cookbookname; }
            set
            {
                if (_cookbookname != value)
                {
                    _cookbookname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public decimal CookbookPrice
        {
            get { return _cookbookprice; }
            set
            {
                if (_cookbookprice != value)
                {
                    _cookbookprice = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CookbookSkillNumber
        {
            get { return _cookbookskillnumber; }
            set
            {
                if (_cookbookskillnumber != value)
                {
                    _cookbookskillnumber = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string CookbookSkill
        {
            get { return _cookbookskill; }
            set
            {
                if (_cookbookskill != value)
                {
                    _cookbookskill = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime CookbookDate
        {
            get { return _cookbookdate; }
            set
            {
                if (_cookbookdate != value)
                {
                    _cookbookdate = value;
                    InvokePropertyChanged();
                }
            }
        }

        public bool Active
        {
            get { return _active; }
            set
            {
                if (_active != value)
                {
                    _active = value;
                    InvokePropertyChanged();
                }
            }
        }

    }
}
