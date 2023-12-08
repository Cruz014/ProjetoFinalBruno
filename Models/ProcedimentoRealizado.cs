using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalBruno.Models
{
    public class ProcedimentoRealizado
    {
        [Column("Id")]
        [Display(Name = "Código ProcedimentoRealizado")]
        public int Id { get; set; }

        [ForeignKey("ClienteId")]
        [Display(Name = "Codigo Do Paciente")]

        public int? ClienteId { get; set; }

        public Cliente? Cliente { get; set; }

        [ForeignKey("ProcedimentoId")]
        [Display(Name = "Codigo Do Procedimento")]

        public int? ProcedimentoId { get; set; }

        public Procedimento? Procedimento { get; set; }

        [ForeignKey("ColaboradorId")]
        [Display(Name = "Codigo Do Colaborador")]

        public int? ColaboradorId { get; set; }

        public Colaborador? Colaborador { get; set; }

        [ForeignKey("LocalRealizacaoId")]
        [Display(Name = "Local Codigo")]

        public int? LocalRealizacaoId { get; set; }

        public LocalRealizacao? LocalRealizacao { get; set; }

        [Column("DataRealizacao")]
        [Display(Name = "Data De Realização")]

        public DateTime DataRealizacao { get; set; }

        [Column("ObersevacaoRealizacao")]
        [Display(Name = "Observação Da Realização")]
        public string ObersevacaoRealizacao { get; set; } = string.Empty;

    }
}
