using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemZarzadzaniaPracownikami
{
    internal class Developer : IEmplojee
    {
        private readonly int hourlyRate;   
        private readonly int hoursWorked;  

        public Developer(int hourlyRate, int hoursWorked)
        {
            this.hourlyRate = hourlyRate;
            this.hoursWorked = hoursWorked;
        }

        public void Work()
        {
            Console.WriteLine("Developer pisze kod i rozwiązuje problemy techniczne.");
        }

        public int GetSalary()
        {
            return hourlyRate * hoursWorked;  
        }
    }
}
