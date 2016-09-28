using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distributeur_De_Cotes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Teacher John = new Teacher("John", "Doe", 3);
            Console.WriteLine(John.DisplayName());
            Activity Math = new Activity(7, "Math","MA01",John);
            Console.ReadKey();
            
        }
        
    }
}
