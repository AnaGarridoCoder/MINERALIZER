using MINERALIZER_API.iServices;
using Entities.Entities;
using Logic.ILogic;

namespace MINERALIZER_API.Services
{
    public class RolService : IRolService
    {
        private readonly IRolLogic _rolLogic;
        public RolService(IRolLogic rolLogic)
        {
            _rolLogic = rolLogic;
        }
        public int InsertRol(RolItem rolItem)
        {
            _rolLogic.InsertRolItem(rolItem);
            return rolItem.Id;
        }
    }
}
