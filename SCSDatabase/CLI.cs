using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
    internal class CLI
    {
        static IStaff LogIn(List<IStaff> staff)
        {
            string username = "";
            string password = "";
            bool running = true;

            while (running)
            {
                Console.Write("LOGIN\n");
                Console.Write("=====\n");
                Console.Write("Username: ");
                username = Console.ReadLine();
                Console.Write("\nPassword: ");
                password = Console.ReadLine();
                for (int i = 0; i<staff.Count; i++)
                {
                    if (username.ToUpper() == staff[i].Username.ToUpper() && password == staff[i].Password)
                    {
                        return staff[i];
                    }
                }
            }
            return staff[0];
        }
        static void Main(string[] args)
        {
            // Creating object lists
            List<Customer> Customers = new List<Customer>();
            List<IProperty> Properties = new List<IProperty>();
            List<IStaff> Staff = new List<IStaff>();
            // Marking the current logged in user
            IStaff CurrentUser;

            // Adding customers
            Customers.Add(new Customer("Jack", "Danger", "Jack@gmail.com", "07123456789"));
            Customers.Add(new Customer("John", "Doe", "John@gmail.com", "07123456788"));
            Customers.Add(new Customer("Sean", "Silver", "Sean@gmail.com", "07123456787"));

            // Adding staff
            Staff.Add(new Cleaning("Ben", "Smith", "Ben@gmail.com", "07123456786", "Ben.Smith", "april"));
            Staff.Add(new Cleaning("Daniel", "Smith", "Daniel@gmail.com", "07123456785", "Daniel.Smith", "may"));
            Staff.Add(new Maintainance("Gary", "Barker", "Gary@gmail.com", "07123456784", "Gary.Barker", "june"));

            // Adding properties
            Properties.Add(new Domestic(Customers[0], "123Street", 200000, Enums.DomesticPropertyType.FLATS));
            Properties.Add(new Domestic(Customers[1], "123Street", 300000, Enums.DomesticPropertyType.BUNGALOWS));
            Properties.Add(new Commercial(Customers[2], "123Street", (float)200000.00, Enums.CommercialPropertyType.OFFICE));

            Properties[0].CreateSignificantService(500, Enums.Levels.MEDIUM, Enums.SignificantServiceType.WATER_DAMAGE);
            Properties[1].CreateCosmeticService(40, Enums.CosmeticServiceType.VACUUMING);
            Properties[2].CreateSignificantService(2000, Enums.Levels.HIGH, Enums.SignificantServiceType.FIRE_DAMAGE);

            CurrentUser = LogIn(Staff);

            if (CurrentUser is Maintainance)
            {
                Console.WriteLine("Wombat");
            }
            else if (CurrentUser is Cleaning)
            {
                Console.WriteLine("Wombat1");
            }
        }
    }
}
