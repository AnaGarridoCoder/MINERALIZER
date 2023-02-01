using Microsoft.AspNetCore.Mvc;
using MINERALIZER_API.iServices;

using MINERALIZER_API.iServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace MINERALIZER_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RolController : ControllerBase
    {
        private readonly IRolService _rolService;
        public RolController(IRolService rolService)
        {
            _rolService = rolService;
        }

        [HttpPost(Name = "InsertRol")]
        public int Post([FromBody] RolItem rolItem) => _rolService.InsertRol(rolItem);
    }
}