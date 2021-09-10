using System;
using System.Collections.Generic;

#nullable disable

namespace EFCore
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Avatar { get; set; }
        public bool Active { get; set; }
        public string UserType { get; set; }

        public virtual Nurse Nurse { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
