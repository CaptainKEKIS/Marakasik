using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2_OOP
{
    class Person
    {
        private string _name;
        private string _secondName;
        private DateTime _birthday;

        public Person()
        {
            _name = "";
            _secondName = "";
            _birthday = DateTime.Today;
        }

        public Person(string Name, string SecondName, DateTime Birthday)
        {
            _name = Name;
            _secondName = SecondName;
            _birthday = Birthday;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value == "111")
                {
                    throw new ArgumentException("Все плохо");
                }
                else
                {
                    _name = value;
                }

            }
        }
        public string SecondName
        {
            get { return _secondName; }
            set { _secondName = value; }
        }
        public DateTime Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        //public int PutIn { get; set; }
        public int GetSetBirthday { get; set; }

        public override string ToString()
        {
            return Name + " " + SecondName + " " + Birthday.ToString("dd.MM.yyyy");
        }

        public virtual string ToShortString()
        {
            return Name + " " + SecondName;
        }
    }
}
