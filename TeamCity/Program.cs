using System;
using static System.Console;


namespace TeamCity
{
    internal class Program
    {
        static int sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            WriteLine(sum(1, 2));
        }
    }
}