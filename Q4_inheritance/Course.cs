using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_inheritance
{
    public class Course
    {
        // Attributes
        private string title;
        private int duration; // Duration in weeks

        // Constructor
        public Course(string title, int duration)
        {
            this.title = title;
            this.duration = duration;
        }

        // Getters and Setters
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
    }

}
