using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1
{
    internal class Employee : Character
    {
        public string Title;
        public double HourlyRate;
        private DateTime HireDate;

        public Employee(
            string firstName, 
            string? lastName, 
            int age, 
            string gender, 
            ConsoleColor color, 
            string title, 
            double hourlyRate
        )
        : base(firstName, lastName, age, gender, color)
        {
            this.Title = title;
            this.HourlyRate = hourlyRate;
            this.HireDate = DateTime.Now;
        }
    }
}
