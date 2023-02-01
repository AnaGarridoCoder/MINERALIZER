using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class OrderItem
    {
        public OrderItem()
        {
            IsActive = true;
        }

        public int Id { get; set; } 
        public Guid IdWeb { get; set; } 
        public int NumberItems { get; set; }
        public int OrderNumber { get; set; }    
        public DateTime InsertDate { get; set; }
        public DateTime UpdateDate { get; set; }  
        public bool IsActive { get; set; }  
      
    }
}
