using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.Business.DataTransferObjects
{
   public class AddRequestProductDto
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public double Discount { get; set; }
        public int? CategoryId { get; set; }
    }
}
