using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public class Significant : IService
	{
		public Levels Priority { get; set; }
		public SignificantServiceType Type { get; set; }
	}
}