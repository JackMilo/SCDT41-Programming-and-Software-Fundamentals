using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public interface IProperty
	{
		public Guid ID { get; set; }
		public Customer Owner { get; set; }
        public List<IService> Services { get; set; }

        public string Address { get; set; }
        public float Price { get; set; }



        public void CreateSignificantService(float _Price, Enums.Levels _Priority, Enums.SignificantServiceType _Type)
        {
            Services.Add(new Significant(_Price, _Priority, _Type));
        }
        public void CreateCosmeticService(float _Price, Enums.CosmeticServiceType _Type)
        {
            Services.Add(new Cosmetic(_Price, _Type));
        }
    }
}