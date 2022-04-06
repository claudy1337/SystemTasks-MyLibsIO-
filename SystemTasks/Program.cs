using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibs;
using System.IO;

namespace SystemTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("напишите комманду:");
            string answer = Convert.ToString(Console.ReadLine());
            if (answer == "read")
            {
                ReadIO read = new ReadIO();
            }
            else if (answer == "shutdown")
            {
                Shutdow shutdow = new Shutdow();
                
            }
            else if(answer == "close")
            {
                CloseApp closeApp = new CloseApp();
            }
            
        }
    }
}
