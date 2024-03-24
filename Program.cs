using TournamentManager.Model;

namespace TournamentManager
{
    internal static class Program
    {

        public static string DefaultDatabaseName = "data.db";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            using (DatabaseDbContext databaseDbContext = new()) {
                await databaseDbContext.Database.EnsureCreatedAsync();
                Application.Run(new MainForm(databaseDbContext));

            }

                
        }
    }
}