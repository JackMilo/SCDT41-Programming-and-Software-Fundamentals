using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Significant : IService
	{
        public Guid ID { get; set; }
        public TimeLog MyTimeLog { get; set; }
        public List<Purchase> Purchases { get; set; }

        public float Price { get; set; }
        public bool Completed { get; set; }
        public Levels Priority { get; set; }
        public SignificantServiceType Type { get; set; }

        public Significant(float _Price, Enums.Levels _Priority, Enums.SignificantServiceType _Type)
        {
            ID = Guid.NewGuid();
            MyTimeLog = new TimeLog();

            Price = _Price;
            Completed = false;
            Priority = _Priority;
            Type = _Type;
        }

        public void CompleteService()
        {
            MyTimeLog.CompletionTime = DateTime.Now;
            MyTimeLog.Difference = MyTimeLog.StartTime - MyTimeLog.CompletionTime;
            Completed = true;
        }

        public void CreatePurchase(float _Cost, string _Name, int _Quantity)
        {
            Purchases.Add(new Purchase(_Cost, _Name, _Quantity));
        }
    }
}