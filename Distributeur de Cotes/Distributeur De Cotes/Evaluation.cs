using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Cotes
{
    class Evaluation
    {
        private Activity activity;
        private int note;
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
        public int Note()
        {
            return note;
        }
    }
}
