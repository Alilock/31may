using System;
using System.Collections.Generic;
using System.Text;

namespace _31may
{
    internal class Employee : Human
    {
        //public Employee(string fullName) : base(fullName)
        //{
        //    FullName = fullName;
        //}
        public int Salary;
        public string Position;


        public void ShowInfo()
        {
            Console.WriteLine($"{FullName}, {Age}yas, {Salary}azn, {Position}");
        }
    }
}
