using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_inheritance
{
    public class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }

        public Person(string name, string id)
        {
            Name = name;
            Id = id;
        }
    }
}
