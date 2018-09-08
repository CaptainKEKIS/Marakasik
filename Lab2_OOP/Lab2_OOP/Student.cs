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
        private Exam _passedExams;

        public Student()
        {
            _student = new Person();
            _formOfTraining = Education.Bachelor;
            _groupNumber = 0;
            _passedExams = new Exam();
        }
        public Student()
        {

        }
    }
}
