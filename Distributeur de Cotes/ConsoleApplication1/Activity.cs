using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1;

namespace ConsoleApplication1
{
    class Activity
    {
        private string name,code;
        private Teacher teacher;
        private int ects;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public int ECTS
        {
            get
            {
                return ects;
            
            }
            set
            {
                ects = value;
            }
        }
        public Teacher Teacher
        {
            get
            {
                return teacher;
            }
            set
            {
                teacher = value;
            }
        }
        public Activity( string name, string code, Teacher teacher, int ects)
        {
            
            ECTS = ects;
            Name = name;
            Code = code;
            Teacher = teacher;
            
            
        }
        
    }
}
