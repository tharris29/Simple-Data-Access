using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("10 rows added and read:{0}",SimpleDBRunner.RunLoad(10));
            Console.WriteLine("100 rows added and read:{0}",SimpleDBRunner.RunLoad(100));
            
            Console.ReadLine();
        }
    }
}
