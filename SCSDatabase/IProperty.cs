using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public interface IProperty
	{
		public Guid ID { get; set; }
		public Customer Owner { get; set; }
        public string Address { get; set; }
        public float Price { get; set; }
        public List<IService> Services { get; set; }

        public void CreateSignificantService()
        {
            Services.Add(new Significant());
        }
        public void CreateCosmeticService()
        {
            Services.Add(new Cosmetic());
        }
    }
}