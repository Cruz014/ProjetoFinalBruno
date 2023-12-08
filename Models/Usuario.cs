using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoFinalBruno.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Código Do Usuario")]
        public int Id { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]

        public string Email { get; set; } = string.Empty;

        [Column("Senha")]
        [Display(Name = "Senha")]

        public string Senha { get; set; } = string.Empty;

    }
}
