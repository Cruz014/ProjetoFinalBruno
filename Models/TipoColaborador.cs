using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalBruno.Models
{
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Código TipoColaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Nome Tipo Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;

    }
}
