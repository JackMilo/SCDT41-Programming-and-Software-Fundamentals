using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Commercial : IProperty
	{
		public CommercialPropertyType Type { get; set; }
	}
}