using Project_1279757.DITests;
using Project_1279757.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1279757
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IRepositoryFactory repoFactory = new RepositoryFactory();
            TestClass test = new TestClass(repoFactory);
            test.Run();
            Console.WriteLine();
            Console.WriteLine("****************************Test 2 ****************************");
            TestClass2 test2 = new TestClass2();
            test2.Run(repoFactory);
            Console.ReadLine();
        }
    }
}
