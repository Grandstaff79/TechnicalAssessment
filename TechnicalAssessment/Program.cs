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
         static void Main(string[] args)
        {
             Console.WriteLine("Please input file name: ");
            Console.ReadLine();
        }
    }
  
}
        public class TextFieldParser : IDisposable {} 
                
            using (TextFieldParser parser = new TextFieldParser(@"C:\Users\TravisGrandstaff\Desktop\rawCSV\names.csv"))
  {
    parser.TextFieldType = FieldType.Delimited;
    parser.SetDelimiters(",");
    while (!parser.EndOfData)
    {
        //Process row
        string[] fields = parser.ReadFields();
        foreach (string field in fields)
        {
            //TODO: Process field
        }
    }
}
            

            var csvTable = new DataTable();
            using (var csvReader = new CsvReader(new StreamReader(File.OpenRead(@"C:\Users\TravisGrandstaff\Desktop\rawCSV\names.csv")), true))
            {
                csvTable.Load(csvReader);
            }

             void Page_Load(object sender, EventArgs e)
{
    SearchFile("prism");
}



 
     void SearchFile(string fileName)
{
    DriveInfo[] allDrives = DriveInfo.GetDrives();
    List<string> files = new List<string>();
    foreach (DriveInfo dir in allDrives)
    {
        if (dir.IsReady)
        {
            DirSearch(dir.Name, fileName, files);
        }
    }
}
              void DirSearch(string dirctoryName, string fileName, List<string> files);

    try
    {      
        foreach (string d in Directory.GetDirectories(dirctoryName))
        {
            foreach (string f in Directory.GetFiles(d, "*" + fileName + "*.*"))
            {
               files.Add(f);
            }
            DirSearch(d, fileName, files);
        }
    }
    catch (System.Exception excpt)
    {
        Response.Write(excpt.Message);
    }



            if (File.Exists("names.csv"))
            {
                Console.WriteLine("The file exists.");
            }
            if (File.Exists(@"C:\names.csv"))
            {
                Console.WriteLine("The file exists.");
            }

           

      

    public class SearchParameters
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }

        }
    

   


        

     


            
                
   
        
    

