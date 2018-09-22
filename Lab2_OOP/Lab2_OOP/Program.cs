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
        class A
        {
            string B = "fdjdskjhfkjhfksjhfkj";
            public string this[int num, string kshgj]
            {
                get{ return  kshgj + B[num]; }
                set { Console.WriteLine(value); }
            }
        }
        static void Main(string[] args)
        {
            A a = new A();
            var bbb = a[3,"fkjhdskjhgf"];
            Console.WriteLine(bbb);
            a[3, "fkjhdskjhgf"] = "1111111111111111111111";

            Person p = new Person();
            Console.WriteLine(p.Name);
            p.Name = "Vasja";
            Console.WriteLine(p.Name);

            Exam e = new Exam();
            Console.WriteLine(e);
        }
    }
}
