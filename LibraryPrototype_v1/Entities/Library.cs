using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryPrototype_v1.Entities;

namespace LibraryPrototype_v1
{
    internal class Library : GameObject
    {
        public double Balance;
        public int DaysPlayed;
        public int Reputation;
        public int TotalVisitors;

        public List<Room> Rooms;
        public List<Employee> Employees;
        //public List<Patron> Patrons;

        public Library(string name, int size, double price)
                : base(name, size, price)
        {
            this.Balance = 1000.00;
            this.DaysPlayed = 0;
            this.Reputation = 0;
            this.TotalVisitors = 0;

            this.Rooms = new List<Room>();
            this.Employees = new List<Employee>();
            //this.Patrons = new List<Patron>();
        }
    }
}
