using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the name of the file");
            string file_name = Console.ReadLine();
            Console.WriteLine(File.ReadAllText(file_name));
        }
    }
}
