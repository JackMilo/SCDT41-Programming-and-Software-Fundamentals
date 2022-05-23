using System;
using System.Collections.Generic;
using System.Text;
using static SCSDatabase.Enums;

namespace SCSDatabase
{
	public interface IStaff
	{
		public Guid ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

		public void BookSignificantService(IProperty Property, float _Price, Enums.Levels _Priority, Enums.SignificantServiceType _Type)
        {
			Property.CreateSignificantService(_Price, _Priority, _Type);
        }
		public void BookCosmeticService(IProperty Property, float _Price, Enums.CosmeticServiceType _Type)
		{
			Property.CreateCosmeticService(_Price, _Type);
		}

		public void CompleteService(IService Service)
		{
			Service.CompleteService();
		}
	}
}