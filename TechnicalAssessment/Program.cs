using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Reflection;
using LumenWorks.Framework.IO.Csv;


namespace TechnicalAssessment
{
    internal class Program
    {
         static void Main()
        {

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"C:\Users\TravisGrandstaff\Desktop\rawCSV\names.csv")), true))
            {
                csvTable.Load(csvReader);
            }


            if (File.Exists("names.csv"))
            {
                Console.WriteLine("The file exists.");
            }
            if (File.Exists(@"C:\names.csv"))
            {
                Console.WriteLine("The file exists.");
            }

            Console.WriteLine("Please input file name: ");
            Console.ReadLine();
        }



    public class SearchParameters
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

        }
    }
}

        

     


            
                
   
        
    

