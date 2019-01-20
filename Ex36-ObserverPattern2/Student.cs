using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern2
{
    public class Student : Person, IStudent
    {
        private IAcademy academy;
        private string message;

        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        public Student(IAcademy academy, string name) : base(name)
        {
            this.academy = academy;
        }

        public void Update()
        {
            Academy academy = ((Academy)this.academy);
            this.message = academy.Message;
            System.Console.WriteLine("Studerende " + Name + " modtog nyheden '" + message + "' fra akadamiet " + academy.Name);
        }
    }
}
