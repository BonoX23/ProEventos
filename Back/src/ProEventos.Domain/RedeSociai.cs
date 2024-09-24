namespace ProEventos.Domain
{
    public class RedeSocial
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string URL { get; set; }
        // Rede social poder ser tanto de evento
        public int? EventoId { get; set; }
        public Evento Evento { get; set; }
        //Quanto de palestrante
        public int? PalestranteId { get; set; }
        public Palestrante Palestrante { get; set; }
    }
}