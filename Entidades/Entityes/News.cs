using Entityes.Notifications;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entityes.Entityes
{
    [Table("TB_NEWS")]
    public class News : Notify
    {
        [Column("NTC_ID")]
        public int Id { get; set; }

        [Column("NTC_TITLE")]
        public string Title { get; set; }

        [Column("NTC_INFORMATION")]
        [MaxLength(255)]
        public string Information { get; set; }

        [Column("NTC_ACTIVE")]
        public bool Active { get; set; }

        [Column("NTC_DATE_REGISTER")]
        public DateTime DateRegister { get; set; }

        [Column("NTC_DATE_UPDATE")]
        public DateTime DateUpdate { get; set; }

        [ForeignKey("ApplicationUser")]
        [Column(Order = 1)]
        public string UserId { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
