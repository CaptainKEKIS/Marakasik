using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP
{
    class Exam
    {
        public string Discipline { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }

        public Exam()
        {
            Discipline = "";
            Mark = 0;
            Date = DateTime.Now;
        }

        public Exam(string Discipline, int Mark, DateTime Date)
        {
            this.Discipline = Discipline;
            this.Mark = Mark;
            this.Date = Date;
        }

        public override string ToString()
        {
            return Discipline + " " + Mark + " " + Date;
        }
    }
}
