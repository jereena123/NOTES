using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace assignment2inheritance
    {
        public class Student : Person
        {
            public int RollNo { get; set; }
            public double Marks { get; set; }

            public Student(string name, int age, int rollNo, double marks)
                : base(name, age)
            {
                RollNo = rollNo;
                Marks = marks;
            }

            public override void DisplayDetails()
            {
                StringBuilder stringBuilder = new StringBuilder();
                base.DisplayDetails();
                stringBuilder.AppendLine($"Roll No: {RollNo}");
                stringBuilder.AppendLine($"Marks: {Marks}");
                Console.WriteLine(stringBuilder.ToString());
            }
        }
    }
