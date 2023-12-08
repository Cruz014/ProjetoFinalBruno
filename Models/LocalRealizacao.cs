using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjetoFinalBruno.Models
{
    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Código LocalRealizacao")]
        public int Id { get; set; }

        [Column("LocalRealizacaoNome")]
        [Display(Name = "Nome Da LocalRealizacaoNome")]
        public string LocalRealizacaoNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade Codigo Do Paciente")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }

    }
}
