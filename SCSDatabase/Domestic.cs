using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Domestic : IProperty
	{
		public DomesticPropertyType Type { get; set; }
	}
}