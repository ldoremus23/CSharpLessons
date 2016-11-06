using CSharpLessons.WorkingWithCollections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello World!\n{Environment.MachineName}\n\n");

            new CollectionsTest().PrintCars();
            Console.ReadLine();
        }
    }
}
