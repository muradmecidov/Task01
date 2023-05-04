using ConsoleApp25.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25.Models
{
    internal class Category: BaseAuditibleEntitiy
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
        
    }
}
