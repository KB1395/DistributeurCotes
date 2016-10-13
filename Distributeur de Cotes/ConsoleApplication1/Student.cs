using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Student : Person
    {
        private List<Evaluation> evaluations;

        public Student(string lastName, string firstName) : base(lastName, firstName)
        {
            evaluations = new List<Evaluation>();
        }

        public void Add(Evaluation evaluation)
        {
            evaluations.Add(evaluation);
        }

        private double avg;
        private double bullavg;
        public double Average()
        {
            var sum = 0;
            foreach (var n in evaluations)
                sum += n.Note();
            avg= sum / evaluations.Count;

            return avg;
        }

        public string Bulletin()
        {
            Dictionary<Activity, Tuple<int, int>> gradesPerActivity = new Dictionary<Activity, Tuple<int, int>>();

            foreach (var g in this.evaluations)
            {
                
                try
                {
                    Tuple<int, int> t = gradesPerActivity[g.Activity];
                    gradesPerActivity[g.Activity] = new Tuple<int, int>(t.Item1 + g.Note(), t.Item2 + 1);
                }
                catch (KeyNotFoundException)
                {
                    gradesPerActivity.Add(g.Activity, new Tuple<int, int>(g.Note(), 1));
                }
            }

            
            string bulletin = this.Lastname + " " + this.Firstname + "\n";

            
            foreach (KeyValuePair<Activity, Tuple<int, int>> entry in gradesPerActivity)
            {
                bullavg = entry.Value.Item1 / entry.Value.Item2;
                bulletin += entry.Key.Code + " " + entry.Key.Name + " " + entry.Key.ECTS + " " + bullavg + "\n";
            }

            bulletin += "\n\n";

            return bulletin;
        }

    }
}