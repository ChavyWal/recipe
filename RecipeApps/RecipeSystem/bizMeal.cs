using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizMeal: bizObject<bizMeal>
    {
        public bizMeal()
        {

        }

        private string _username = "";
        private string _mealname;
        private string _totalcalories;
        private int _numcourses;
        private int _numrecipes;
        private bool _active = true;
        private string _mealdesc = "";
        
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

        public string MealName
        {
            get { return _mealname; }
            set
            {
                if (_mealname != value)
                {
                    _mealname = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string MealDesc
        {
            get { return _mealdesc; }
            set
            {
                if (_mealdesc != value)
                {
                    _mealdesc = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string totalCalories
        {
            get { return _totalcalories; }
            set
            {
                if (_totalcalories != value)
                {
                    _totalcalories = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int numCourses
        {
            get { return _numcourses; }
            set
            {
                if (_numcourses != value)
                {
                    _numcourses = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int numRecipes
        {
            get { return _numrecipes; }
            set
            {
                if (_numrecipes != value)
                {
                    _numrecipes = value;
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
