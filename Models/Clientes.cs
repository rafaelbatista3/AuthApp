using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AuthApp.Models
{ 
    [Table ("Clientes")]

    public class Clientes : LinksHATEOS
    {
        [Key]
        public int Id { get; set;  }
        
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Nome { get; set; }
        
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string email {  get; set; }
        public string CNPJ { get; set; }
        public string Endereço { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        
       
    }
}
