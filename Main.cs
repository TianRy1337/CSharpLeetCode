using System;
namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RomanToInt.Solution solution = new RomanToInt.Solution();
            int _int = solution.RomanToInt("III");
            Console.WriteLine(_int);
        }
    }
}
