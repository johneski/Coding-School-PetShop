using PetShopLibrary;

namespace Session_11
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

            PetShopManager petShop = new PetShopManager();
            petShop.Add(new Employee()
            {
                Name = "Admin",
                Surname = "",
                ObjectStatus = PetShopLibrary.DataObjects.Status.Active,
                Salary = 0,
                Type = EmployeeType.Manager
            });
            ApplicationConfiguration.Initialize();
            Application.Run(new PetShopForm(petShop));
        }
    }
}