using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public interface IService
	{
		public Guid ID { get; set; }
        public TimeLog MyTimeLog { get; set; }
        public List<Purchase> Purchases { get; set; }

        public float Price { get; set; }
        public bool Completed { get; set; }

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