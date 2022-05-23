using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public class Customer : IPerson
	{
        public Guid ID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Customer(string _FName, string _SName, string _Email, string _Phone)
        {
            ID = Guid.NewGuid();
            FName = _FName;
            SName = _SName;
            Email = _Email;
            Phone = _Phone;
        }

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
    }
}