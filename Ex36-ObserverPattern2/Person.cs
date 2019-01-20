using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern2
{
    public class Person
    {
        private readonly string name;

        public string Name
        {
            get { return this.name; }
        }

        public Person(string name)
        {
            this.name = name;
        }
    }
}
