using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mylib;

namespace Практика_6_горох
{
    class Program
    {
        static void Main(string[] args)
        {
        a:
            Console.WriteLine("Choice");
            int vibor = Convert.ToInt32(Console.ReadLine());
            switch (vibor)
            {

                case 1:
                    Console.Clear();
                    student.Prosmotr();
                    Console.ReadLine();
                    goto a;
                case 2:
                    int Id = Convert.ToInt32(Console.ReadLine());
                    string name = Console.ReadLine();
                    string group = Console.ReadLine();
                    string Date = Console.ReadLine();
                    student.ADD(Id, name, group, Date);
                    Console.Clear();
                    goto a;
                case 3:
                    Id = Convert.ToInt32(Console.ReadLine());
                    student.Delete(Id);
                    Console.Clear();
                    goto a;
                case 4:
                    Console.Clear();
                    student.Fio();
                    Console.ReadLine();
                    goto a;
                case 5:
                    Id = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    student.PoiskID(Id);
                    Console.ReadLine();
                    goto a;
                case 6:
                    Id = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    student.Years(Id);
                    goto a;
            }
        }
    }
}
