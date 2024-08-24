using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppClinicManagementSystem.Model
{
    public class Test
    {
        public int TestId { get; set; }
        public string TestName { get; set; }
        public decimal TestAmount { get; set; }

        public Test() { }

        public Test(int testId, string testName, decimal testAmount)
        {
            TestId = testId;
            TestName = testName;
            TestAmount = testAmount;
        }
    }
}
