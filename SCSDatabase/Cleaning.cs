using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public class Cleaning : IPerson, IStaff
	{
        public Guid ID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public List<Purchase> Purchases { get; set; }

        public void UpdateInfo()
        {
            Console.WriteLine("Update:\nFirst Name:");
            FName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Last Name:");
            SName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Email:");
            Email = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Phone:");
            Phone = Convert.ToString(Console.ReadLine());
        }

        public void BookSignificantService(IProperty Property, float _Price, Enums.Levels _Priority, Enums.SignificantServiceType _Type)
        {
            Property.CreateSignificantService(_Price, _Priority, _Type);
        }
        public void BookCosmeticService(IProperty Property, float _Price, Enums.CosmeticServiceType _Type)
        {
            Property.CreateCosmeticService(_Price, _Type);
        }

        public void CompleteService(IService Service)
        {
            Service.CompleteService();
        }

        public void RequestPurchase()
        {
            Purchases.Add(new Purchase());
        }
    }
}