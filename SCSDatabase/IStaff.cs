using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
	public interface IStaff
	{
		public Guid ID { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }

		public void BookService()
        {

        }

		public void CompleteService()
		{

		}
	}
}