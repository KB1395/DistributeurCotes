using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Appreciation : Evaluation
    {
        private string appreciation;

        public Appreciation(Activity activity, string appreciation) : base(activity)
        {
            this.appreciation = appreciation;
        }
        public override int Note()
        {
            switch (this.appreciation)
            {
                case "N":
                    return 20;
                case "C":
                    return 16;
                case "B":
                    return 12;
                case "TB":
                    return 8;
                case "X":
                    return 4;
                default:
                    return 0;
            }
        }

        public void setAppreciation(string appreciation)
        {
            this.appreciation = appreciation;
        }
    }
    }

