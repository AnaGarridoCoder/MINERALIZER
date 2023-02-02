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
        public int InsertMineralItem(MineralItem mineralItem)
        {
            _mineralLogic.InsertMineralItem(mineralItem);
            return mineralItem.Id;
        }
        public void DeleteMineralItem(int Id)
        {
            _mineralLogic.DeleteMineralItem(Id);
        }

        public void UpdateMineralItem(MineralItem mineralItem)
        {
            _mineralLogic.UpdateMineralItem(mineralItem);
        }

        public List<MineralItem> GetAllMineralItems()
        {
            return _mineralLogic.GetAllMineralItems();
        }
    }
}
