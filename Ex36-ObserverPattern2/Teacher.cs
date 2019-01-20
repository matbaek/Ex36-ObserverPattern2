using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern2
{
    public class Teacher : Person
    {
        private string jobTitle;

        public Teacher(string name) : base(name) { }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }
    }
}
