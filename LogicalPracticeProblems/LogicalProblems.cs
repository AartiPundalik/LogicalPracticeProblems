﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPracticeProblems
{
    public class LogicalProblems
    {
        public void Checkevenorodd()
        {
            int Number;
            Console.Write("Enter The Number: ");
            Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.Write("Entered Number is an Even Number");
            }
            else
            {
                Console.Write("Entered Number is an Odd Number");
            }
            Console.ReadLine();
        }
    public void checkswap()
    {
        int num1, num2, temp;

        Console.WriteLine("Enter first number");
        num1 = 100;
        Console.ReadLine();

        Console.WriteLine("Enter second number");

        num2 = 200;
        Console.ReadLine();

        Console.WriteLine("Values before swapping: num1=" + num1 + " and num2=" + num2);

        temp = num1;

        num1 = num2;

        num2 = temp;

        Console.WriteLine("Values after swapping: num1=" + num1 + " and num2=" + num2);

        Console.ReadLine();
    }
        public void checkLargestNumber()
        {
            int num1, num2;

            Console.WriteLine("Find the largest of two numbers:");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Input the 1st number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the  2nd number :");
            num2 = Convert.ToInt32(Console.ReadLine());
           

            if (num1 > num2)
            {
              
                    Console.WriteLine("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.WriteLine("The 2nd Number is the greatest among three.");
                }
            }
          
    }
}

    

