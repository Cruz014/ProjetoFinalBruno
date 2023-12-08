using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalBruno.Models
{
    public class Cidade
    {
        [Column("Id")]
        [Display(Name = "Código Cidade")]
        public int Id { get; set; }

        [Column("CidadeNome")]
        [Display(Name = "Cidade Do Paciente")]
        public string CidadeNome { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        [Display(Name = "Estado Codigo Do Paciente")]

        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }

    }
}