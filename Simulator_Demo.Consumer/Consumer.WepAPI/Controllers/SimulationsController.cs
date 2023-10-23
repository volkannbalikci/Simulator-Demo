using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Producer.Business.Abstract;
using Producer.Business.Constants;
using Producer.Entities.Concrete;
using System.Net.Sockets;

namespace Consumer.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SimulationsController : ControllerBase
    {
        private readonly ILogger _logger;
        private readonly ISimulationService _simulationService;
        public SimulationsController(ILogger logger, ISimulationService simulationService)
        {
            _logger = logger;
            _simulationService = simulationService;
        }

        [HttpGet("CreateSimulator")]
        public IActionResult CreateSimulation(int clientNumber, Random rnd, List<SocketDataModel> socketDataModels, List<Socket> sockets)
        {
            _simulationService.CreateSimulation(clientNumber, rnd, socketDataModels, sockets);
            return Ok(Messages.SimulationCreatedMessage);
        }
    }
}
