using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Exames_Clinpop.Shared.Modelos
{
    public class Exame
    {
        [Key]
        public int ExameId { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string? NomeExame { get; set; }

        [Required]
        [MaxLength(200)]
        public string? DescricaoExame { get; set; }

        [Required]
        [Column(TypeName = "decimal(12,2)")]
        public decimal Preco { get; set; }
    }
}
