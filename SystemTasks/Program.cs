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
            try
            {
                Console.Write("напишите комманду:");
                string answer = Convert.ToString(Console.ReadLine()).ToLower();
                switch (answer)
                {
                    case "read":
                        ReadIO read = new ReadIO();
                        break;
                    case "shutdown":
                        Shutdow shutdow = new Shutdow();
                        break;
                    case "close":
                        CloseApp closeApp = new CloseApp();
                        break;
                    case "restart":
                       
                        break;
                    default:
                        break;

                }

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
            
        }
    }
}
