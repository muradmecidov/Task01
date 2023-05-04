using ConsoleApp25.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25.Models
{
    internal class Book: BaseAuditibleEntitiy
    {
       
        public string Title { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public string Quantitiy { get; set; }
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        






    }
}
