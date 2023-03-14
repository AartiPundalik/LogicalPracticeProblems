using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            LogicalProblems logicalProblems = new LogicalProblems();
            logicalProblems.Checkevenorodd();
            logicalProblems.checkswap();
            logicalProblems.checkLargestNumber();
            logicalProblems.checkReverse();
            logicalProblems.PositiveOrNegative();
            logicalProblems.OddNumber();
            logicalProblems.DivisibleByTwo();
            logicalProblems.SumOfDigit();
            logicalProblems.MultiplesOf3And5(1000);
            Console.ReadLine();
        }
    }

}
    

