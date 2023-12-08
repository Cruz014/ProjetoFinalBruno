using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProjetoFinalBruno.Models
{
    public class Colaborador
    {
        [Column("Id")]
        [Display(Name = "Código Colaborador")]
        public int Id { get; set; }

        [Column("ColaboradorNome")]
        [Display(Name = "Nome Do Colaborador")]
        public string ColaboradorNome { get; set; } = string.Empty;

        [Column("ColaboradorCpf")]
        [Display(Name = "Cpf Do Colaborador")]
        public string ColaboradorCpf { get; set; } = string.Empty;

        [Column("ColaboradorSexo")]
        [Display(Name = "Sexo Do Colaborador")]
        public string ColaboradorSexo { get; set; } = string.Empty;

        [Column("ColaboradorTelefone")]
        [Display(Name = "Telefone Do Colaborador")]
        public string ColaboradorTelefone { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade Codigo Do Paciente")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }


        [ForeignKey("TipoColaboradorId")]
        [Display(Name = "TipoColaborador Codigo")]

        public int TipoColaboradorId { get; set; }

        public TipoColaborador? TipoColaborador { get; set; }
    }
}