using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class MineralItem
    {
        public MineralItem() {
            IsActive = true;
            IsPublic = true;
        }

        public int Id { get; set; } 
        public Guid IdWeb { get; set; }
        public UserItem OwnerUser { get; set; } 
        public DateTime InsertDate { get; set; }    
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }  
        public decimal RawPrice { get; set; }   
    }
}
