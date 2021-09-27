using System;
using System.IO;

namespace ExceptionsPage83
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("C:\\QaLearning\\UserData.txt");
                string line = sr.ReadToEnd();
                Console.WriteLine(line);
            }

            catch
            {
                Console.WriteLine("Please create file!");
            }

            finally
            {
                Console.WriteLine("Operation is finished");
            }
        }
    }
}
