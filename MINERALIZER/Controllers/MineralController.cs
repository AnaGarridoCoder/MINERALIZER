using MINERALIZER_API.iServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MINERALIZER_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MineralController : ControllerBase
    {
        private readonly IMineralService _mineralService;
        public MineralController(IMineralService mineralService)
        {
            _mineralService = mineralService;
        }

        [HttpPost(Name = "InsertMineral")]
        public int Post([FromBody] MineralItem mineralItem) => _mineralService.InsertMineral(mineralItem);
    }
}
