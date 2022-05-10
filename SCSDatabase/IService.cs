using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	internal interface IService
	{
		public Guid ID { get; set; }
		public float Cost { get; set; }
	}
}