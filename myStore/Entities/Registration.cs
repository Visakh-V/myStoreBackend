using System;
using System.Collections.Generic;

namespace myStore.Entities
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Mobile { get; set; }
        public int? RoleId { get; set; }

        public virtual Users Role { get; set; }
    }
}
