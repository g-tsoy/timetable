using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {   const string file = "../../timetable.txt";
                string line;
                using (StreamReader sr = new StreamReader(file))
                {
                    line = sr.ReadToEnd();
                    Console.WriteLine(line);
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            //string adress = "../../timetable.txt";
            //string file;
            //using (var sr = new StreamReader(adress))
            //{
            //    file=sr.ReadToEnd();
            //}

            //Console.WriteLine(file);
            //Console.ReadLine();
        }
    }
}
