using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP
{
    class Exam
    {
        public string Discipline { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }

        public Exam()
        {
            Discipline = "";
            Score = 0;
            Date = DateTime.Today;
        }

        public Exam(string Discipline, int Score, DateTime Date)
        {
            this.Discipline = Discipline;
            this.Score = Score;
            this.Date = Date;
        }

        public override string ToString()
        {
            return Discipline + " " + Score + " " + Date;
        }
    }
}
