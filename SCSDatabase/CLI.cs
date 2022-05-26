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



        static void MaintainanceMenu(IStaff CurrentUser, List<IProperty> Properties, List<IStaff> Staff)
        {
            string answer;

            Console.WriteLine("Maintainance Staff Menu");
            Console.WriteLine("=======================");
            Console.WriteLine("Book Service [1]");
            Console.WriteLine("Complete Service [2]");
            Console.WriteLine("Logout [3]");
            Console.Write("Input: ");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    BookingMenu(CurrentUser, Properties);
                    break;
                case "2":
                    Console.Clear();
                    CompleteServiceMenu(CurrentUser, Properties);
                    break;
                case "3":
                    Console.Clear();
                    CurrentUser = LogIn(Staff);
                    break;
            }
        }

        static void CleaningMenu(IStaff CurrentUser, List<IProperty> Properties, List<IStaff> Staff)
        {
            string answer;

            Console.WriteLine("Cleaning Staff Menu");
            Console.WriteLine("=======================");
            Console.WriteLine("Book Service [1]");
            Console.WriteLine("Complete Service [2]");
            Console.WriteLine("Request Purchase [3]");
            Console.WriteLine("Logout [4]");
            Console.Write("Input: ");
            answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    BookingMenu(CurrentUser, Properties);
                    break;
                case "2":
                    Console.Clear();
                    CompleteServiceMenu(CurrentUser, Properties);
                    break;
                case "3":
                    Console.Clear();
                    RequestPurchaseMenu(CurrentUser);
                    break;
                case "4":
                    Console.Clear();
                    CurrentUser = LogIn(Staff);
                    break;
            }
        }

        static void BookingMenu(IStaff CurrentUser, List<IProperty> Properties)
        {
            string answer;

            Console.WriteLine("Booking Menu");
            Console.WriteLine("=======================");
            Console.WriteLine("Book Significant Service [1]");
            Console.WriteLine("Book Cosmetic Service [2]");
            Console.Write("Input: ");
            answer = Console.ReadLine();
            if (answer == "1")
            {
                int propertyNum = 1;
                float price = 1;
                Enums.Levels priority = Enums.Levels.LOW;
                Enums.SignificantServiceType type = Enums.SignificantServiceType.WATER_DAMAGE;

                Console.WriteLine("Booking Menu");
                Console.WriteLine("=======================");
                Console.WriteLine("Property Number: ");
                propertyNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price: ");
                price = (float)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Priority Level: ");
                priority = (Enums.Levels)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Service type");
                type = (Enums.SignificantServiceType)Convert.ToInt32(Console.ReadLine());
                CurrentUser.BookSignificantService(Properties[propertyNum], price, priority, type);
            }
            else if (answer == "2")
            {
                int propertyNum = 1;
                float price = 1;
                Enums.Levels priority = Enums.Levels.LOW;
                Enums.CosmeticServiceType type = Enums.CosmeticServiceType.DUSTING;

                Console.WriteLine("Booking Menu");
                Console.WriteLine("=======================");
                Console.WriteLine("Property Number: ");
                propertyNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price: ");
                price = (float)Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Priority Level: ");
                priority = (Enums.Levels)Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Service type");
                type = (Enums.CosmeticServiceType)Convert.ToInt32(Console.ReadLine());
                CurrentUser.BookCosmeticService(Properties[propertyNum], price, type);
            }
        }

        static void CompleteServiceMenu(IStaff CurrentUser, List<IProperty> Properties)
        {
            int propertyNum = 1;
            int serviceNum = 1;

            Console.WriteLine("Complete Service Menu");
            Console.WriteLine("=======================");
            Console.WriteLine("Property Number: ");
            propertyNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Service Number: ");
            serviceNum = Convert.ToInt32(Console.ReadLine());
            CurrentUser.CompleteService(Properties[propertyNum].Services[serviceNum]);
        }

        static void RequestPurchaseMenu(IStaff CurrentUser)
        {
            float cost;
            string name;
            int quantity;

            Console.WriteLine("Cost: ");
            cost = (float)Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Quantity: ");
            quantity = Convert.ToInt32(Console.ReadLine());

            ((Cleaning)CurrentUser).RequestPurchase(cost, name, quantity);
        }



        static void Main(string[] args)
        {
            // Creating object lists
            List<Customer> Customers = new List<Customer>();
            List<IProperty> Properties = new List<IProperty>();
            List<IStaff> Staff = new List<IStaff>();
            // Marking the current logged in user
            IStaff CurrentUser;
            // Exit value
            bool running = true;
            // Answer holder
            string answer;

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

            // Adding services
            Properties[0].CreateSignificantService(500, Enums.Levels.MEDIUM, Enums.SignificantServiceType.WATER_DAMAGE);
            Properties[1].CreateCosmeticService(40, Enums.CosmeticServiceType.VACUUMING);
            Properties[2].CreateSignificantService(2000, Enums.Levels.HIGH, Enums.SignificantServiceType.FIRE_DAMAGE);

            // Login process
            CurrentUser = LogIn(Staff);

            while (running)
            {
                Console.Clear();
                if (CurrentUser is Maintainance)
                {
                    MaintainanceMenu(CurrentUser, Properties, Staff);
                }
                else if (CurrentUser is Cleaning)
                {
                    CleaningMenu(CurrentUser, Properties, Staff);
                }
            }
        }
    }
}
