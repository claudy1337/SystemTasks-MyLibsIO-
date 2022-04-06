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
            output.Close();
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
