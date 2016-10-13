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
            this.evaluations = new List<Evaluation>();
        }

        public void Add(Evaluation evaluation)
        {
            this.evaluations.Add(evaluation);
        }

        
        public double Average()
        {
            var sum = 0;
            foreach (var n in evaluations)
                sum += n.Note();

            return sum / this.evaluations.Count;
        }

        // Constructs a string representing the average score for each activity of the student
        public string Bulletin()
        {

            // The evaluations can be assigned to any activity and are not sorted
            // We first need to sort them by activity to be able to take an average
            // For this we create a dictionary (hashmap) where the key is an activity and the value is a tuple of two integers
            // representing the running sum of the scores for that activity and the number of evaluations.
            // For each activity we check if it already exists in the dictionary, if it does we update the sum and number
            // otherwise we add the activity
            Dictionary<Activity, Tuple<int, int>> gradesPerActivity = new Dictionary<Activity, Tuple<int, int>>();

            foreach (var g in this.evaluations)
            {
                // We try to access a given key in the dictionary, if it does not exist it will throw an exception
                // and we know we have to add it to the dictionary.
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

            // We construct the string to print out, beginning with the name of the student on the first line
            string bulletin = this.Lastname + " " + this.Firstname + "\n";

            // And a line for every activity with the code, name, ects and score
            foreach (KeyValuePair<Activity, Tuple<int, int>> entry in gradesPerActivity)
            {
                bulletin += entry.Key.Code + " " + entry.Key.Name + " " + entry.Key.ECTS + " " + entry.Value.Item1 / entry.Value.Item2 + "\n";
            }

            bulletin += "\n\n";

            return bulletin;
        }

    }
}