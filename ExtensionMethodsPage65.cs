using System;

namespace ExtensionMethodsPage65
{
    public static class IntExtensions
    {
        public static void GetVariableValue(this int value)
        {
            Console.WriteLine($"\"Value of your variable is {value}\".");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 1010;
            i.GetVariableValue();
        }
    }
}
