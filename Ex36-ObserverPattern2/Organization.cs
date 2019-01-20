using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern2
{
    public class Organization
    {
        private readonly string name;
        private string address;

        public string Name
        {
            get { return name; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public Organization(string name)
        {
            this.name = name;
        }
    }
}
