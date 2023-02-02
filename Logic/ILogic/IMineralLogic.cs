using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IMineralLogic
    {
        int InsertMineralItem(MineralItem mineralItem);
        void DeleteMineralItem(int Id);
        void UpdateMineralItem(MineralItem mineralItem);
        List<MineralItem> GetAllMineralItems();
    }
}
