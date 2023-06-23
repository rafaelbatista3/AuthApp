using AuthApp.Models;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;


namespace AuthApp.Models
{
    public class Orcamento
    {
        public int Id { get; set; }
        public Clientes Clientes { get; set; }
        public int ClientesId { get; set; }

        public ICollection<Servicos> Serviços { get; set; }

        public int ServicosId { get;set; }
      
    }
}
