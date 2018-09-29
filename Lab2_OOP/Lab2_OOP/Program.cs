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
        static void func(params string[] str)
        {
            foreach (var s in str)
                Console.WriteLine(s);
        }
        /*
        class A
        {
            string B = "fdjdskjhfkjhfksjhfkj";
            public string this[int num, string kshgj]
            {
                get { return kshgj + B[num]; }
                set { Console.WriteLine(value); }
            }
        }
        */

        static void Main(string[] args)
        {
            /*
            func("fsafsd", "fdsafsda"); func(new []{"fsdhfjhsdjkhfd","111!"});
            A a = new A();
            var bbb = a[3, "fkjhdskjhgf"];
            Console.WriteLine(bbb);
            a[3, "fkjhdskjhgf"] = "1111111111111111111111";

            Person p = new Person();
            Console.WriteLine(p.Name);
            p.Name = "Vasja";
            Console.WriteLine(p.Name);

            Exam e = new Exam();
            Console.WriteLine(e);
            */

            DateTime Birthday = new DateTime(1990, 8, 20);
            Person p = new Person("Vasya", "Ivanov", Birthday);
            Console.WriteLine(p.ToString());
            Student student = new Student(p, Education.Bachelor, 0112003);
            Console.WriteLine(student.ToShortString());
            Console.WriteLine(student[Education.Specialist]);
        }
    }
}
