 using MessagePack;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit.Sdk;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace AuthApp.Models

{
    [Table("Servicos")]
    public class Servicos
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Tipo { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        [Column(TypeName ="decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage = "Este campo é obrigatório.")]
        public string Descricao { get; set; }

       

    }
}
