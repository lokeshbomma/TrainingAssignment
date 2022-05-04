using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_6
{
    class InterfaEg
    {
        static void Main()
        {

            IStudent obj = new DayScholar();
            obj.DisplayDetails(1, "lokesh");


            IStudent obj1 = new Resident();
            obj1.DisplayDetails(2, "rakesh");

            Console.ReadLine();
        }
    }
}
