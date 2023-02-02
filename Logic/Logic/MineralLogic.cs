using Data;
using Entities.Entities;
using Logic.ILogic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Logic
{
    public class MineralLogic : BaseContextLogic, IMineralLogic
    {
        public MineralLogic(ServiceContext serviceContext) : base(serviceContext) { }

      

        public int InsertMineralItem(MineralItem mineralItem)
        {
            _serviceContext.Mineral.Add(mineralItem);
            _serviceContext.SaveChanges();
            return mineralItem.Id;
        }  
        void IMineralLogic.DeleteMineralItem(int Id)
        {
            _serviceContext.Mineral.Remove(_serviceContext.Set<MineralItem>().Where(p => p.Id == Id).FirstOrDefault());
            _serviceContext.SaveChanges();
        }
        public void UpdateMineralItem(MineralItem mineralItem)
        {
            _serviceContext.Mineral.Update(mineralItem);
            _serviceContext.SaveChanges();
        }
        public List<MineralItem> GetAllMineralItems()
        {
            return _serviceContext.Set <MineralItem>().ToList();
        }
    }
}
