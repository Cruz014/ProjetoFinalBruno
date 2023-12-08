using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProjetoFinalBruno.Models
{
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Código TipoProcedimento")]
        public int Id { get; set; }

        [Column("ObservacaoRealizacao")]
        [Display(Name = "Observação Da Realização")]
        public string ObservacaoRealizacao { get; set; } = string.Empty;


    }
}
