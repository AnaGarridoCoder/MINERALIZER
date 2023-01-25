using MINERALIZER_API.iServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MINERALIZER_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MineralController : ControllerBase
    {
        private readonly ILogger<MineralController> _logger;
        private readonly IMineralService _mineralService;
        public MineralController(ILogger<MineralController> logger, IMineralService mineralService)
        {
            _logger = logger;
            _mineralService = mineralService;
        }

        [HttpPost(Name = "InsertMineral")]
        public int Post([FromBody] MineralItem mineralItem)
        {
            return _mineralService.InsertMineral(mineralItem);
        }
    }
}
