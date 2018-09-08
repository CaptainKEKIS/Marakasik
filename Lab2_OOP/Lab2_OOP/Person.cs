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
            _birthday = DateTime.Now;
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
        public string SecondName { get; set; }
        public DateTime Birthday { get; set; }
        //public int PutIn { get; set; }
        public int GetSetBirthday {get; set;}

        public override string ToString()
        {
            return _name + " " + _secondName + " " + _birthday;
        }

        public virtual string ToShortString() {
            return _name + " " + _secondName;
        }
    }
}
