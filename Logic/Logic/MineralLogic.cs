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
        public void InsertMineralItem(MineralItem mineralItem)
        {
            _serviceContext.Minerals.Add(mineralItem);
            _serviceContext.SaveChanges();
        }
    }
}
