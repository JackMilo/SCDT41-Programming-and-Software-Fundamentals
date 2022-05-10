using System;
using System.Collections.Generic;
using System.Text;

namespace SCSDatabase
{
    internal interface IPerson
    {
        public Guid ID { get; set; }
        public string FName { get; set; }
        public string SName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}