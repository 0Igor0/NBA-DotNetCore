using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DREAM_TEAM_NBA.Models
{
    [Table("Players")]
    public class Player
    {
        [Key]
        public int PlayerID { get; set; }
        [Required(ErrorMessage = "O nome do jogador deve ser informado")]
        [Display(Name = "Nome do Jogador")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Name { get; set; }
        [Display(Name = "Posição")]
        public string Position { get; set; }
        [Display(Name = "Caminho Imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string Img { get; set; }
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
    }
}
