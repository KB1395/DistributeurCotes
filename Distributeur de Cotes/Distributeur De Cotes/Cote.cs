using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Cotes
{
    class Grade:Evaluation
    {
        public int grade;
        public Grade(Activity activity, int grade):base(activity)
        {
            this.grade = grade;
        }
        
        
        public override int Note()
        {
            return grade;
        }
        public void setNote(int grade)
        {

            this.grade = grade;
        }
    }
}
