using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLocalFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the sum is {0}", AddWrapper(5, 9));

        }

         static int AddWrapper(int x, int y)
        {
            //do some validation here
            return Add();
          int  Add()
          {
                return (x + y);
          }
        }

        
    }
}
