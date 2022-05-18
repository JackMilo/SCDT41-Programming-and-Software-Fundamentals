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
    }
}