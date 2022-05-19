using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public interface IService
	{
		public Guid ID { get; set; }
        public DateTime StartTime { get; set; }
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

        public void CreatePurchase()
        {
            Purchases.Add(new Purchase());
        }
    }
}