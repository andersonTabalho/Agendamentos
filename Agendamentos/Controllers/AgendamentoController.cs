using barbearia.Domain.Interfaces.Applications;
using barbearia.Domain.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;

namespace barbearia.WebApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentosController(IAgendamentoApp agendamentoApp) : ControllerBase
    {
        private readonly IAgendamentoApp _agendamentoService = agendamentoApp;

        [HttpPost]
        public IActionResult CriarAgendamento([FromBody] AgendamentoRequest agendamentoRequest)
        {
            _agendamentoService.Adicionar(agendamentoRequest);
            return Ok();
        }
    }
}