using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalBruno.Models
{
    public class Estado
    {
        [Column("Id")]
        [Display(Name = "Código Estado")]
        public int Id { get; set; }

        [Column("EstadoNome")]
        [Display(Name = "Estado Nome")]
        public string EstadoNome { get; set; } = string.Empty;
    }
}

