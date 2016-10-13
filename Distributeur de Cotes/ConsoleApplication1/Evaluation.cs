using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Evaluation
    {
        public Activity activity;
        
        public Activity Activity
        
        {
            get
            {
                return activity;
            }
            set
            {
                activity = value;
            }
        }
        public abstract int Note();
        
        
        public Evaluation(Activity activity)
        {
            this.Activity = activity;
        }
        
    }
}
