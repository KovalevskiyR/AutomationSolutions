using System;
using System.Reflection;

namespace ReflectionPage86
{
    class Program
    {
        static void Main(string[] args)
        {
            PropertyInfo[] myPropertyInfo;
            myPropertyInfo = Type.GetType("System.String").GetProperties();
            Console.WriteLine("Properties of System.String are:");
            foreach (var properties in myPropertyInfo)
            {
                Console.WriteLine(properties);
            }
        }
    }
}
