using MINERALIZER_API.iServices;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using Data;

namespace MINERALIZER_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MineralController : ControllerBase
    {

        private readonly IMineralService _mineralService;
        private readonly ServiceContext serviceContext;
        public MineralController(IMineralService mineralService)
        {
            _mineralService = mineralService;

        }

        [HttpPost(Name = "InsertMineral")]
        public int Post([FromHeader] string userName, [FromHeader] string userPassword, [FromBody] MineralItem mineralItem) => _mineralService.InsertMineralItem(mineralItem);

        [HttpDelete(Name = "DeleteMineralItem")]
        public void Delete([FromQuery] int Id)
        
            {
                _mineralService.DeleteMineralItem(Id);
            }
        

        [HttpPatch(Name = "ModifyMineral")]
        public void Patch([FromBody] MineralItem mineralItem)
        {
            _mineralService.UpdateMineralItem(mineralItem);
        }


        [HttpGet(Name = "GetAllMineralItems")]
        public List<MineralItem> GetAll()
        {
            //     _userService.ValidateCredentials(userItem);
            return _mineralService.GetAllMineralItems();

        }
    }
}