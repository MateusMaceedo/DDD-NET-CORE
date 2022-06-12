using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoModeloDDD.Domain.Entities
{
    [Table("TB_CLIENTES")]
    public class Cliente
    {
        // Estados
        [Key]
        public int ClientId { get; set; }

        [Required]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$",ErrorMessage ="CPF informado não é válido")]

        public string CPF { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="Nome não pode ter mais de 50 caracteres")]

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        // Comportamentos
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
        }

        public void Update(string cpf, string nome)
        {
            this.CPF = cpf;
            this.Nome = nome;
        }
    }
}
