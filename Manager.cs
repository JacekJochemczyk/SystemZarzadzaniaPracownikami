using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarzadzaniaPracownikami
{
    internal class Manager : IEmplojee
    {
        private readonly int salary;  

        public Manager(int salary)
        {
            this.salary = salary;
        }

        public void Work()
        {
            Console.WriteLine("Manager zarządza zespołem i koordynuje projekty.");
        }

        public int GetSalary()
        {
            return salary;  
        }
    }
}
