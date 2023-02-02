using Entities.Entities;

namespace MINERALIZER_API.iServices
{
    public interface IMineralService
    {
        int InsertMineralItem(MineralItem mineralItem);

        void DeleteMineralItem(int Id);

        void UpdateMineralItem(MineralItem mineralItem);

        List<MineralItem> GetAllMineralItems();
    }
}
