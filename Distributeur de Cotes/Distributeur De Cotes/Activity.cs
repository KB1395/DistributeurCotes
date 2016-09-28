using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Distributeur_De_Cotes;

namespace Distributeur_De_Cotes
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
        public Activity(int ects, string name, string code, Teacher teacher)
        {
            
            ECTS = ects;
            Name = name;
            Code = code;
            Teacher = teacher;
            
            
        }
        
    }
}
