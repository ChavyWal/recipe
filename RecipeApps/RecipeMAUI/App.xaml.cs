namespace RecipeMAUI
{
    public partial class App : Application
    {
        public static bool loggedin = false;
        public static string connstringSetting = "";
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
