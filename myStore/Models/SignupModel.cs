using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myStore.Models
{
    public class SignupModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int? RoleId { get; set; }
    }
}
