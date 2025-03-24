namespace barbearia.Application.Commands
{
    public class CriarAgendamentoCommand
    {
        public Guid ClienteId { get; set; }
        public Guid BarbeiroId { get; set; }
        public DateTime DataHora { get; set; }
    }
}