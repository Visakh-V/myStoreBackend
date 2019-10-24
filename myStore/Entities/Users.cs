using System;
using System.Collections.Generic;

namespace myStore.Entities
{
    public partial class Users
    {
        public Users()
        {
            Registration = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public string Role { get; set; }

        public virtual ICollection<Registration> Registration { get; set; }
    }
}
