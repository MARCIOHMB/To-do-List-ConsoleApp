using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_do_List__ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine("Hello, Welcome to the C# Console To Do List Application");
            Console.WriteLine("---------------------------------------------------------------------------------");

            Console.ReadLine();

            List list = new List();
            list.Startup();



            Console.ReadKey();
        }
    }
}
