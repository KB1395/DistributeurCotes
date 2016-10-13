using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cote:Evaluation
    {
        public int cote;
        public Cote(Activity activity, int cote):base(activity)
        {
            this.cote = cote;
        }
        
        
        public override int Note()
        {
            return cote;
        }
        public void setNote(int cote)
        {

            this.cote = cote;
        }
    }
}
