using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TechnicalAssessment
{
    internal class Program
    {
     static void Main(string[] args)
        {
           
            Console.WriteLine("Please input file name: ");
            Console.ReadLine();

            DirectoryInfo place = new DirectoryInfo(@"C:\Users\TravisGrandstaff\Desktop\Emails\names.csv");
            FileInfo[] Files = place.GetFiles();

            foreach (FileInfo i in Files)
            {
                Console.WriteLine("File Name - {0}", i.Name);
            }
           


            
        }
    }
}
