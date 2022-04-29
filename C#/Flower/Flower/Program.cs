using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flower
{
    internal class Program
    {
        public class flower1
        {
            public String name;
            public String color;
            public flower1(String name,String color)
            {
                this.name = name;
                this.color = color;
                Console.WriteLine($"name is {name} & color is {color}");
            }
        }
        class flowervas
        {
            flower1[] flow = new flower1[5];
            for(int i = 0; i<flow.Length; i++)
			{
                public flower1 this[int indexPos] { }
			}
        }
        static void Main(string[] args)
        {
            flower1 f = new flower1("datura","red");
            Console.ReadLine();
        }
    }
}
