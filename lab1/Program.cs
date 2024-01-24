using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the rectangle: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of the rectangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

          
            double area = length * width;

           
            Console.WriteLine("The area of the rectangle is:  " +area );
            Console.ReadLine();
        }
    }
}
