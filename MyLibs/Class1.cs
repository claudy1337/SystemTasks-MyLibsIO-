using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MyLibs
{
    public class ReadIO
    {
        public ReadIO()
        {
            Console.Write("file name:");
            
            string str = Console.ReadLine();
            string allowedchar = "0123456789";

            if (!str.All(allowedchar.Contains))
            {
                Console.WriteLine("123323");
            }
            else
            {
                if (str.Length < 5 && (!string.IsNullOrEmpty(str)))
                {
                    Console.Write($"{str}.txt:");
                    string write = Convert.ToString(Console.ReadLine());
                    string filePath = @"D:\" + str + ".txt";
                    string text = write;
                    FileStream fileStream = null;
                    if (!File.Exists(filePath))
                        fileStream = File.Create(filePath);
                    else
                        fileStream = File.Open(filePath, FileMode.Append);
                    StreamWriter output = new StreamWriter(fileStream);
                    output.Write(text);
                }
            }
            //output.Close();
            Console.ReadKey();
        }  
    }
    public class Shutdow
    {
        public Shutdow()
        {
            Console.WriteLine("выключение через...");
            System.Diagnostics.Process.Start("Shutdown", "-s -t 10");
        }
    }
    public class CloseApp
    {
        public CloseApp()
        {
            Console.WriteLine("закрытие через...");
            Environment.Exit(5);
        }
    }

}
