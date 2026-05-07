using Inventory_Manager.Services;

namespace Inventory_Manager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var dbService = new SupabaseService();
            var inventoryService = new InventoryService(dbService);

            LoginForm loginForm = new LoginForm(inventoryService, dbService);

            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            else
            {
                Application.Exit();
            }
        }
    }
}