using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2_Ism_4300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter expected grade for ISM 4300.");
            int n1 = Convert.ToInt32(Console.ReadLine());
            if (n1 > 97 )
            {
                Console.WriteLine("That grade is an A+");
                Console.ReadKey(true);
            }
            else if ((n1 > 91)&&(n1 < 98))
            {
                Console.WriteLine("That grade is an A");
                Console.ReadKey(true);
            }
            else if ((n1 > 89) && (n1 < 92))
            {
                Console.WriteLine("That grade is an A-");
                Console.ReadKey(true);
            }
            else if ((n1 > 87) && (n1 < 90))
            {
                Console.WriteLine("That grade is a B+");
                Console.ReadKey(true);
            }
            else if ((n1 > 81) && (n1 < 88))
            {
                Console.WriteLine("That grade is a B");
                Console.ReadKey(true);
            }
            else if ((n1 > 79) && (n1 < 82))
            {
                Console.WriteLine("That grade is a B-");
                Console.ReadKey(true);
            }
            else if ((n1 > 77) && (n1 < 80))
            {
                Console.WriteLine("That grade is a C+");
                Console.ReadKey(true);
            }
            else if ((n1 > 71) && (n1 < 78))
            {
                Console.WriteLine("That grade is a C");
                Console.ReadKey(true);
            }
            else if ((n1 > 69) && (n1 < 72))
            {
                Console.WriteLine("That grade is a C-");
                Console.ReadKey(true);
            }
            else if ((n1 > 67) && (n1 < 70))
            {
                Console.WriteLine("That grade is a D+");
                Console.ReadKey(true);
            }
            else if ((n1 > 61) && (n1 < 68))
            {
                Console.WriteLine("That grade is a D");
                Console.ReadKey(true);
            }
            else if ((n1 > 59) && (n1 < 62))
            {
                Console.WriteLine("That grade is a9 D-");
                Console.ReadKey(true);
            }
            else
            {
                Console.WriteLine("That grade an F");
                Console.ReadKey(true);
            }
        }
    }
}
