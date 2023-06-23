namespace AuthApp.Models
{
    public class TotalOrcamento
    {
        public int ID { get; set; }
        public int ClienteID { get; set; }
        public List<Orcamento> OrcamentoLista { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime? DataOrcamento { get; set; }
    }
}
