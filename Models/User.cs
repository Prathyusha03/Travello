using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Travello.Models
{
    public class User
    {
        public int id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }

        public String Email{ get; set; }
        public String Phonenumber { get; set; }
    }
}
