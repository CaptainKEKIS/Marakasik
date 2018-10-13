using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
            Console.SetIn(new StreamReader("1.txt",Encoding.GetEncoding(1251)));
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
            */


            ////////////
            int n = 4;
            Exam[] e = new Exam[n];
            string Discipline;
            int Score = 0;
            for (int i = 0; i < n; i++) {
                e[i] = new Exam();
                Console.WriteLine("Введите дисциплину");
                Discipline = Console.ReadLine();
                Console.WriteLine("Введите оценку");
                Score = Convert.ToInt32(Console.ReadLine());
                e[i].Discipline = Discipline;
                e[i].Score = Score;
                e[i].Date = DateTime.Parse(Console.ReadLine());

            }
            /////////////

            

            DateTime Birthday = new DateTime(1990, 8, 20);
            Person p = new Person("Vasya", "Ivanov", Birthday);
            Student student = new Student(p, Education.Bachelor, 0112003);
            Console.WriteLine(student[Education.Specialist]);
            student.AddExams(e);
            student.AddExams(e);
            Console.WriteLine(student.ToShortString());
        }
    }
}
