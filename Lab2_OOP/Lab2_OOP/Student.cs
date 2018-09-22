using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP
{
    class Student
    {
        private Person _student;
        private Education _formOfTraining;
        private int _groupNumber;
        private Exam[] _passedExams;

        public Student()
        {
            _student = new Person();
            _formOfTraining = Education.Bachelor;
            _groupNumber = 0;
            _passedExams = new Exam[0];
        }

        public Student(Person Student, Education FormOfTraining, int GroupNumber)
        {
            _student = Student;
            _formOfTraining = FormOfTraining;
            _groupNumber = GroupNumber;
        }

        public Person Person { get; set; }
        public Education FormOfTraining { get; set; }
        public int GroupNumber { get; set; }
        public Exam[] PassedExams { get; set; }

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
                if(this.FormOfTraining == FormOfTraining){
                    return true;
                }
                return false;
            }
        }

    }
}
