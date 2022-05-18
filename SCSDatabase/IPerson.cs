using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
    public interface IPerson
    {
        public Guid ID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public void UpdateInfo()
        {

        }
    }
}