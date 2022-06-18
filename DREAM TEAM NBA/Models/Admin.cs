using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DREAM_TEAM_NBA.Models
{
    [Table("Admin")]
    public class Admin
    {
        [Column("Id")]
        [Display(Name = "código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [Column("Password")]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }
    }
}
