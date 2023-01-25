using MINERALIZER_API.iServices;
using Entities.Entities;
using Logic.ILogic;

namespace MINERALIZER_API.Services
{
    public class MineralService : IMineralService
    {
        private readonly IMineralLogic _mineralLogic;
        public MineralService(IMineralLogic mineralLogic)
        {
            _mineralLogic = mineralLogic;
        }
        public int InsertMineral (MineralItem mineralItem)
        {
            _mineralLogic.InsertMineralItem(mineralItem);
            return mineralItem.Id;
        }
    }
}
