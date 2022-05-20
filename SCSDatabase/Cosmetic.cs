using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Cosmetic : IService
	{
        public Guid ID { get; set; }
        public DateTime StartTime { get; set; }
        public TimeLog MyTimeLog { get; set; }
        public List<Purchase> Purchases { get; set; }

        public float Price { get; set; }
        public bool Completed { get; set; }
        public CosmeticServiceType Type { get; set; }

        public Cosmetic(float _Price, Enums.CosmeticServiceType _Type)
        {
            ID = Guid.NewGuid();
            StartTime = DateTime.Now;
            MyTimeLog = new TimeLog();

            Price = _Price;
            Completed = false;
            Type = _Type;
        }

        public void CompleteService()
        {
            MyTimeLog.CompletionTime = DateTime.Now;
            MyTimeLog.Difference = MyTimeLog.StartTime - MyTimeLog.CompletionTime;
            Completed = true;
        }

        public void CreatePurchase()
        {
            Purchases.Add(new Purchase());
        }
    }
}