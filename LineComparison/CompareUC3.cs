﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblemsDay8.LineComparison
{
    internal class CompareUC3
    {
        public static void Compare()
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;                 //defining line points
            double firstLength, secLength;
            Console.WriteLine("Enter X1 point");            //take input from user
            x1 = Convert.ToInt32(Console.ReadLine());         //read user input and convert it to integer bcz in C# default input is in string
            Console.WriteLine("Enter y1 point");           //take input from user
            y1 = Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer
            Console.WriteLine("Enter X2 point");            //take input from user
            x2 = Convert.ToInt32(Console.ReadLine());       //read user input and convert it to integer
            Console.WriteLine("Enter Y2 point");            //take input from user
            y2 = Convert.ToInt32(Console.ReadLine());       //read user input and convert it to integer
            Console.WriteLine("Enter X3 point");            //take input from user
            x3 = Convert.ToInt32(Console.ReadLine());       //read user input and convert it to integer
            Console.WriteLine("Enter y3 point");            //take input from user
            y3 = Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer
            Console.WriteLine("Enter X4 point");            //take input from user
            x4 = Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer
            Console.WriteLine("Enter Y4 point");            //take input from user
            y4 = Convert.ToInt32(Console.ReadLine());        //read user input and convert it to integer

            firstLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));       //Calculating Length
            Console.WriteLine("first Length is:" + Math.Round(firstLength, 2));         //result round to two decimal points and display
            secLength = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));         //Calculating length
            Console.WriteLine("Second Length is :" + Math.Round(secLength, 2));         //result round to two decimal points and display

            int diffLength = firstLength.CompareTo(secLength);                        //Compare two lines length and result store in diffLength
            Console.WriteLine("\nUsing CompareTo Method");
            if (diffLength == 0)                                                //checking lines length equal,less ,greater than second 
                Console.WriteLine("Lines are equal");
            else if (diffLength > 0)
                Console.WriteLine("First Line Length is greater than Second line Length");
            else
                Console.WriteLine("first Line Length is less than Second line Length");
        }
    }
}
