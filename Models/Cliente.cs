using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace ProjetoFinalBruno.Models
{
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome Do Cliente")]
        public string ClienteNome { get; set; } = string.Empty;

        [Column("ClienteCpf")]
        [Display(Name = "Cpf Do Cliente")]
        public string ClienteCpf { get; set; } = string.Empty;

        [Column("ClienteeSexo")]
        [Display(Name = "Sexo Do Cliente")]
        public string ClienteSexo { get; set; } = string.Empty;

        [Column("ClienteTelefone")]
        [Display(Name = "Telefone Do Cliente")]
        public string ClienteTelefone { get; set; } = string.Empty;

        [Column("ClienteEndereco")]
        [Display(Name = "Endereço Do Cliente")]
        public string ClienteEndereco { get; set; } = string.Empty;

        [Column("ClienteNumero")]
        [Display(Name = "Numero Do Cliente")]
        public string ClienteNumero { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Cidade Codigo Do Paciente")]

        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }


    }
}
