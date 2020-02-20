using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string Prefix(int input){
        if(input % 2 == 0){
            return "Even";
        }
        else
        {
            return "Odd";
        }
    }
    }

    
}
