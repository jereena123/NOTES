using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicalManagementSystem.Model
{
    public class Token
    {
        public int TokenId { get; set; }
        public int TokenNumber { get; set; }
        public DateTime TokenDate { get; set; } = DateTime.Now;
    }
}
