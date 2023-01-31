using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsualiton__Academy_Task
{
    internal class Student
    {
        public string FullName;
        private int  _age = 15;

        public int Age
        {
            set
            {
                if (value >= 15)
                    _age = value;
            }
            get
            {
                return _age;
            }
        }
    }
}
