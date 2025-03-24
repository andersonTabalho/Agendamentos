using Agendamentos.Domain.Interfaces.Applications;
using Agendamentos.Domain.ViewModels.Request;
using Microsoft.AspNetCore.Mvc;

namespace Agendamentos.WebApi
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