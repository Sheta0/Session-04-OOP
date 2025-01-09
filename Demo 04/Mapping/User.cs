using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_04.Mapping
{
    // Entity , Model Class
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string CardNumber { get; set; }
        public DateOnly ExpireDate { get; set; }
    }
}
