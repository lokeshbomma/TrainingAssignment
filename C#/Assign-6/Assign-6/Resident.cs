using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign_6
{
    class Resident:IStudent
    {
        public void DisplayDetails(int Id, string Name)
        {
            Console.WriteLine("Student id is.......:{0}", Id);
            Console.WriteLine("Name of the Student is.......:{0}", Name);
        }
    }
}
