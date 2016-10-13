using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Student> students = readStudents("../../students.csv");
            List<Teacher> teachers = readTeachers("../../teachers.csv");


            List<Activity> activities = readActivity("../../activities.csv", teachers);

            readGrades("../../grades.csv", students, activities);

            foreach (Student student in students)
            {
                File.WriteAllText("../../Bulletin-" + student.Lastname + "-" + student.Firstname + ".txt", student.Bulletin());
            }
        }
        public static List<Student> readStudents(string path)
        {

            
            string[] lines = System.IO.File.ReadAllLines(path);

            List<Student> students = new List<Student>();

                        foreach (string line in lines)
            {
                List<string> elems = line.Split(',').Select(elem => elem.Trim()).ToList<string>();
                students.Add(new Student(elems[0], elems[1]));
            }

            return students;
        }


        
        public static List<Teacher> readTeachers(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            List<Teacher> teachers = new List<Teacher>();

            foreach (string line in lines)
            {
                List<string> elems = line.Split(',').Select(elem => elem.Trim()).ToList<string>();
                teachers.Add(new Teacher(elems[0], elems[1], Int32.Parse(elems[2])));               
            }

            return teachers;
        }


       
        public static List<Activity> readActivity(string path, List<Teacher> teachers)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            List<Activity> activities = new List<Activity>();

            foreach (string line in lines)
            {
                List<string> elems = line.Split(',').Select(elem => elem.Trim()).ToList<string>();

                
                activities.Add(new Activity(elems[0], elems[1], teachers.Find(t => t.Lastname == elems[2]), Int32.Parse(elems[3])));
            }

            return activities;
        }


        
        public static void readGrades(string path, List<Student> students, List<Activity> activities)
        {
            string[] lines = System.IO.File.ReadAllLines(path);

            foreach (string line in lines)
            {
                List<string> elems = line.Split(',').Select(elem => elem.Trim()).ToList<string>();

                Evaluation grade;

                
                try
                {
                    grade = new Cote(activities.Find(a => a.Code == elems[1]), Int32.Parse(elems[2]));
                }
                catch (FormatException)
                {
                    grade = new Appreciation(activities.Find(a => a.Code == elems[1]), elems[2]);
                }

                
                students.Find(s => s.Lastname == elems[0])
                        .Add(grade);
            }
        }

    }
}
