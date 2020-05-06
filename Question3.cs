using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM3
{
    class Question3
    {
        public static void greaterThan80(List<int> list)
        {
            Console.WriteLine("The numbers greater than 80 are:");
            foreach (int i in list)
            {
                if (i > 80)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
