using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Grade:Evaluation
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
