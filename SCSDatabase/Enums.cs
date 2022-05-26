using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public class Enums
	{
		public enum CommercialPropertyType
		{
			OFFICE,
			RENTAL,
			INDUSTRIAL,
			LEISURE,
			HEALTHCARE
		}
		public enum DomesticPropertyType
		{
			FLATS,
			DETACHED,
			SEMI_DETACHED,
			TERRACED,
			COTTAGE,
			BUNGALOWS
		}

		public enum Levels
		{
			HIGH = 1,
			MEDIUM = 2,
			LOW = 3
		}

		public enum SignificantServiceType
		{
			FIRE_DAMAGE = 1,
			SMOKE_DAMAGE = 2,
			WATER_DAMAGE = 3
		}
		public enum CosmeticServiceType
		{
			VACUUMING = 1,
			MOPPING = 2,
			DUSTING = 3
		}
		public enum SigOrCom
        {
			SIGNIFICANT,
			COSMETIC
        }
	}
}