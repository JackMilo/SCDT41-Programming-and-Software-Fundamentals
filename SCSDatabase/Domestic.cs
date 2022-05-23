using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Domestic : IProperty
	{
        public Guid ID { get; set; }
        public Customer Owner { get; set; }
        public List<IService> Services { get; set; }

        public string Address { get; set; }
        public float Price { get; set; }
        public DomesticPropertyType Type { get; set; }

        public Domestic(Customer _Owner, string _Address, float _Price, Enums.DomesticPropertyType _Type)
        {
            ID = Guid.NewGuid();
            Owner = _Owner;

            Address = _Address;
            Price = _Price;
            Type = _Type;
        }

        public void CreateSignificantService(float _Price, Enums.Levels _Priority, Enums.SignificantServiceType _Type)
        {
            Services?.Add(new Significant(_Price, _Priority, _Type));
        }
        public void CreateCosmeticService(float _Price, Enums.CosmeticServiceType _Type)
        {
            Services?.Add(new Cosmetic(_Price, _Type));
        }
    }
}