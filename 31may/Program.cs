using System;

namespace _31may
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Layihe run olanda bizden say istesin. Daha sonra hemin say qeder employee  datalari daxil etmeyimizi istesin
            //butun employeeri daxil etdikden sonra filterleme aparib aparmaq istemediyimi sorussun aparmaq istemesek butun employeeleri gostersin 
            //aparsaq filtirlenmis employeeleri gostersin.Adı təyin olunmamış Human yaradıla bilminməz.

            Console.WriteLine("Isci sayini daxil edin: ");
            int countEmp=int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[countEmp];
            for (int i = 0; i < countEmp; i++)
            {
                Console.Write( i+1  + ". Iscinin ad ve soyadini daxil edin ");
               string fullname = Console.ReadLine();
                Console.Write(i+1 + ". Iscinin yasini daxil edin: ");
                byte old = byte.Parse(Console.ReadLine());
                Console.WriteLine(i+1 + ". Iscinin vezifesini daxil edin: ");
                string position = Console.ReadLine();
                Console.WriteLine(i+1 + ". Iscinin maasini daxil edin: ");
                int salary = int.Parse(Console.ReadLine());
                employees[i] = new Employee();
                employees[i].Age = old;
                employees[i].Position = position;
                employees[i].Salary = salary;
                employees[i].FullName = fullname;

                
            }

            Console.WriteLine("Filtirleme aparmaq isteyirsinizmi? Yes-y, No-n");
            string check = Console.ReadLine();
            if (check == "y")
            {
                Console.WriteLine("Minimum maasi daxil edin: ");
                int minSalary = int.Parse(Console.ReadLine());
                Console.WriteLine("Maximum maasi daxil edin: ");
                int maxSalary = int.Parse(Console.ReadLine());
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Salary >= minSalary && employees[i].Salary<=maxSalary )
                    {
                        employees[i].ShowInfo();
                    }
                }
                
                
                
            }

        }
    }
}
