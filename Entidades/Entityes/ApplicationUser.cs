using Entityes.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entityes.Entityes
{
    public class ApplicationUser : IdentityUser
    {
        [Column("USR_AGE")]
        public int Age { get; set; }

        [Column("USR_PHONE")]
        public string Phone { get; set; }

        [Column("USR_TYPE")]
        public TypeUser? Type { get; set; }
    }
}
