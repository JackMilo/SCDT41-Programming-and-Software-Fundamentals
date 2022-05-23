using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public class Purchase
	{
        public Guid ID { get; set; }
        public float Cost { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        public Purchase(float _Cost, string _Name, int _Quantity)
        {
            ID = Guid.NewGuid();
            Cost = _Cost;
            Name = _Name;
            Quantity = _Quantity;
        }
    }
}