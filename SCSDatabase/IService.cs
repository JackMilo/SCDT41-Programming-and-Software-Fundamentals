using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public interface IService
	{
		public Guid ID { get; set; }
        public DateTime StartTime { get; set; }
        public float Price { get; set; }
        public bool Completed { get; set; }
        public TimeLog timeLog { get; set; }

        public void CompleteService()
        {

        }

        public void CreatePurchase()
        {

        }
    }
}