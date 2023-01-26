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
        public string MineralType { get; set; }
        public int MineralSize { get; set; }
        public string MagicProperties { get; set; }
        public decimal RawPrice { get; set; }   
        public bool IsActive { get; set; }
        public bool IsPublic { get; set; }  
        
    }
}
