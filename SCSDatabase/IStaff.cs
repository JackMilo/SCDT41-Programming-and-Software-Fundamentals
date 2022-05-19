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

		public void BookService(IProperty Property, Enums.SigOrCom SorC)
        {
			if (SorC == Enums.SigOrCom.SIGNIFICANT)
            {
				Property.CreateSignificantService();
            }
            else 
			{
				Property.CreateCosmeticService();
			}
        }

		public void CompleteService(IService Service)
		{
			Service.CompleteService();
		}
	}
}