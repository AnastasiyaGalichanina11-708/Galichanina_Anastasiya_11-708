using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Instagram.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }

        public int? RoleId { get; set; }
        public Role Role { get; set; }
    }
}
