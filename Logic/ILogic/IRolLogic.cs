using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ILogic
{
    public interface IRolLogic
    {
        void InsertRol(RolItem rol);
        void InsertRolItem(RolItem rolItem);
    }
}
