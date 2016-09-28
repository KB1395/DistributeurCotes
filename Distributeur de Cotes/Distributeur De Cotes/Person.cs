using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Cotes
{
    class Person
    {
        private string firstname, lastname;
        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

        }
        public string DisplayName()
        {
            string fullname;
            fullname= (firstname +' '+ lastname);
            return fullname;

        }
    }
}
