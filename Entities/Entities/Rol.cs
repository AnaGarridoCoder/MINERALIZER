using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class Rol : UserItem

    {
        public int Id { get; set; }
        public Guid IdWeb { get; set; }
        public string Admin { get; set; }
        public string Client { get; set; }
        public string Support { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }

    }
}
