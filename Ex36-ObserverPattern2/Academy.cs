using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern2
{
    public class Academy : Organization, IAcademy
    {
        private List<IStudent> students = new List<IStudent>();
        private string message;

        public string Message
        {
            get { return message; }
            set {
                message = value;
                Notify();
            }
        }

        public Academy(string name, string address) : base(name)
        {
            this.Address = address;
        }

        public void Attach(IStudent s)
        {
            students.Add(s);
        }

        public void Detach(IStudent s)
        {
            students.Remove(s);
        }

        public void Notify()
        {
            foreach (Student s in students)
            {
                s.Update();
            }
        }
    }
}
