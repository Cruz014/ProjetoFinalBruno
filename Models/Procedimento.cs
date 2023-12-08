using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalBruno.Models
{
    public class Procedimento
    {
        [Column("Id")]
        [Display(Name = "Código Procedimento")]
        public int Id { get; set; }

        [Column("ProcedimentoNome")]
        [Display(Name = "Nome Do Procedimento")]
        public string ProcedimentoNome { get; set; } = string.Empty;

        [Column("ProcedimentoObservacao")]
        [Display(Name = "Oberservação Do Procedimento")]
        public string ProcedimentoObservacao { get; set; } = string.Empty;

        [ForeignKey("EstadoId")]
        [Display(Name = "Estado Codigo Do Paciente")]

        public int EstadoId { get; set; }

        public Estado? Estado { get; set; }

    }
}