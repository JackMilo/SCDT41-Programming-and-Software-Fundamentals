using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Cosmetic : IService
	{
		public CosmeticServiceType Type { get; set; }
	}
}