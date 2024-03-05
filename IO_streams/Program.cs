using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_streams
{
     class Program
     {
        static void Main(string[] args)
        {
            string Check = "C:\\BridgeLabz\\Demo.txt";
            //File.Create(check);
            if (File.Exists(check)) { Console.WriteLine("Exists"); }
            Directory.CreateDirectory(check);
            if (Directory.Exists(check)) { Console.WriteLine("Succeed"); }
            if (File.Exists(check))
            {

            }
            else
            {
                Console.WriteLine("Empty");
            }
            File.WriteAllText(check, "Hello seven");
            string check = @"C:\BridgeLabz\Demo1.csv";
            string check1 = @"C:\BridgeLabz\Demo4.csv";
            File.Create(check1);
            if (File.Exists(check1)) { Console.WriteLine("true"); }
            File.Copy(check, check1);
            File.Move(check, check1);
            string[] list = new string[]
             {

                 "Name  ,Age",
                  "Dileep","23",
                  "Murali","22",
                 "Aramsetti"
            };
        File.WriteAllLines(check, list);
             string[] line = File.ReadAllLines(check1);
             foreach(var lines in line) Console.WriteLine(lines);
              File.Delete(check2);
              using (FileStream fl = new FileStream(Check, FileMode.Create, FileAccess.ReadWrite))
               {
                using (StreamWriter sw = new StreamWriter(fl))
                {
                    sw.WriteLine("Aramsetti");
                    sw.WriteLine("Dileep kumar");

                }
                }
              using (FileStream fs = new FileStream(check, FileMode.Open))
               {
              using (StreamReader sr = new StreamReader(fs))
                   {
                 string lin;
                  while ((lin = sr.ReadLine()) != null)
                    {
                    Console.WriteLine(lin);
                     }
                     }
                     }
             using (FileStream fl = new FileStream(Check, FileMode.Append))
              {
                using (StreamWriter sw = new StreamWriter(fl))
                  {
                  sw.WriteLine("Banglore");
                  sw.WriteLine("BrideLabz");

                   }
                   }
                using (FileStream fl = new FileStream(Check, FileMode.Truncate))
                  {

                       }

                         File.Create("C:\\BridgeLabz\\excel.csv");
                        List<Employee> employees = new List<Employee>()
                        {
                       new Employee(){name="dileep",age=23,department="EEE"},
                       new Employee(){name="murali",age=22,department="ECE"},
                        new Employee(){name="shashank",age=21,department="CSE"}
                        };
            /* using (StreamWriter sw=new StreamWriter("C:\\BridgeLabz\\excel.csv"))
               {
                   foreach (Employee emp in employees) 
                   {
                       sw.WriteLine($"{emp.name},{emp.age},{emp.department}");
                   }
               }*/
            /* string[] s = new string[employees.Count];
             for (int i = 0; i < s.Length; i++) 
             {
                 s[i] = $"{employees[i].name},{employees[i].age},{employees[i].department}";
             }*/
            //Employee employe = new Employee() {name="hello",age=34,department="Bye"};
            Console.WriteLine(File.Exists("C:\\BridgeLabz\\excel.csv"));
            List<string> lines = new List<string>();
            foreach (Employee emp in employees)
            {
                lines.Add($"{emp.name},{emp.age},{emp.department}");
            }
            File.WriteAllLines("C:\\BridgeLabz\\excel.csv", lines);
            string[] a = File.ReadAllLines("C:\\BridgeLabz\\excel.csv");
            foreach (string line in a) { Console.WriteLine(line); }


        }
     }
  public  class Employee
    {
        public string name {  get; set; }
        public int age { get; set; }
        public  string department { get; set; }
     
    }
}
