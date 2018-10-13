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
        private string _groupNumber;
        private Exam[] _passedExams = new Exam[0];

        public Student()
        {
            _person = new Person();
            _formOfTraining = Education.Bachelor;
            _groupNumber = "0";
        }

        public Student(Person Person, Education FormOfTraining, string GroupNumber)
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
        public string GroupNumber
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
                float AvgScore = 0;
                int ScoreSum = 0;
                for (int i = 0; i < _passedExams.Length; i++)
                {
                    ScoreSum += _passedExams[i].Score;
                }
                AvgScore = ScoreSum / _passedExams.Length;
                return AvgScore;
            }
        }
        public bool this[Education FormOfTraining]
        {
            get
            {
                return this.FormOfTraining == FormOfTraining;
            }
        }

        public void AddExams(params Exam[] Exams)
        {
            Exam[] Passed = new Exam[_passedExams.Length + Exams.Length];

            Array.Copy(_passedExams, Passed, _passedExams.Length);
            Array.Copy(Exams, 0, Passed, _passedExams.Length, Exams.Length);

            /*int i = 0;
            for (int j = 0; j < _passedExams.Length; j++) {
                Passed[i] = _passedExams[j];
                i++;
            }
            for (int j = 0; j < Exams.Length; j++) {
                Passed[i] = Exams[j];
                i++;
            }*/
            _passedExams = Passed;

        }
        
        public override string ToString()
        {
            string result = String.Format("Студент: {0}" + Environment.NewLine + "Форма обучения: {1}" + Environment.NewLine + "Номер группы: {2}", _person, _formOfTraining, _groupNumber);
            result += Environment.NewLine + "Сданные экзамены:";
            if (_passedExams.Length != 0)
            {
                for (int i = 0; i < _passedExams.Length; i++)
                {
                    result += Environment.NewLine + "\t" + (i + 1) + ")" + _passedExams[i];
                }
            }
            else
            {
                result += Environment.NewLine + "\tСданных экзаменов нет!";
            }
            return result;
        }

        public virtual string ToShortString()
        {
            return String.Format("{0} Форма обучения: {1} Номер группы: {2} Средний балл: {3}", Person, FormOfTraining, GroupNumber, AvgScore);
        }
    }
}
