using System;
using static System.Console;


namespace TeamCity
{
    public class Program
    {
        static public int sum(int a,int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            WriteLine(sum(2, 3));
        }
    }
}