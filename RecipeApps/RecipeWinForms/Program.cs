using CPUFramework;

namespace RecipeWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //SQLUtility.ConnectionString = "Server=tcp:dev-cw.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info=False;User ID=cwadmin;Password=Chw280qc;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            Application.Run(new frmMain());
        }
    }
}