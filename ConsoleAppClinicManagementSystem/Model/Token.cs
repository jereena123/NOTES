using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Token
    {
        public int TokenId { get; set; }
        public int TokenNumber { get; set; }
        public DateTime TokenDate { get; set; } = DateTime.Now;
        public Token() { }
        public Token(int tokenId, int tokenNumber, DateTime tokenDate)
        {
            TokenId = tokenId;
            TokenNumber = tokenNumber;
            TokenDate = tokenDate;
        }
    }
}
