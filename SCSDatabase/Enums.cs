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
			HIGH,
			MEDIUM,
			LOW
		}

		public enum SignificantServiceType
		{
			FIRE_DAMAGE,
			SMOKE_DAMAGE,
			WATER_DAMAGE
		}
		public enum CosmeticServiceType
		{
			VACUUMING,
			MOPPING,
			DUSTING
		}
		public enum SigOrCom
        {
			SIGNIFICANT,
			COSMETIC
        }
	}
}