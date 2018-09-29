using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP
{
    class Student
    {
        private Person _person;
        private Education _formOfTraining;
        private int _groupNumber;
        private Exam[] _passedExams;

        public Student()
        {
            _person = new Person();
            _formOfTraining = Education.Bachelor;
            _groupNumber = 0;
            _passedExams = new Exam[0];
        }

        public Student(Person Person, Education FormOfTraining, int GroupNumber)
        {
            _person = Person;
            _formOfTraining = FormOfTraining;
            _groupNumber = GroupNumber;
        }

        public Person Person
        {
            get { return _person; }
            set { _person = value; }
        }
        public Education FormOfTraining
        {
            get { return _formOfTraining; }
            set { _formOfTraining = value; }
        }
        public int GroupNumber
        {
            get { return _groupNumber; }
            set { _groupNumber = value; }
        }
        public Exam[] PassedExams
        {
            get { return _passedExams; }
            set { _passedExams = value; }
        }

        public double AvgScore
        {
            get
            {
                return 1 / 1;
            }
        }
        public bool this[Education FormOfTraining]
        {
            get
            {
                if (this.FormOfTraining == FormOfTraining)
                {
                    return true;
                }
                return false;
            }
        }

        void AddExams(params Exam[] Exams)
        {
            foreach (var e in Exams)
            {

            }
        }

        public override string ToString()
        {
            string result = _person + " " + _formOfTraining + " " + _groupNumber;
            for (int i = 0; i < _passedExams.Length; i++)
            {
                result += " " + _passedExams[i];
            }
            return result;
        }

        public virtual string ToShortString()
        {
            return Person + " " + FormOfTraining + " " + GroupNumber + " "; // DABAVIT SREDNIY BALL
        }

    }
}
