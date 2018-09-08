using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_OOP
{
    enum Education { Specialist, Bachelor, SecondEducation };

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.Name);
            p.Name = "Vasja";
            Console.WriteLine(p.Name);

            Exam e = new Exam();
            Console.WriteLine(e);
        }
    }
}
