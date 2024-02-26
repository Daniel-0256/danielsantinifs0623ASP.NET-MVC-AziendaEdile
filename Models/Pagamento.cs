namespace AziendaEdile.Models
{
    public class Pagamento
    {
        public int Id { get; set; }
        public int DipendenteId { get; set; }
        public DateTime Periodo { get; set; }
        public decimal Ammontare { get; set; }
        public bool Stipendio { get; set; }
    }
}
