//****************************************************************************
//****************************************************************************
//
// Tai Dunn
// CSCI 1301CD
// Programming Assignment 1
// 01/29/2020
//
// Sorter.cs
//
//***************************************************************************
//***************************************************************************

using System;
using System.Collections.Generic;

namespace Programming_Assignment_1
{
   class SorterTwo
   {
      static void Main(string[] args)
      {
         //Initializing 'i' you will see more how this is used below.'
         int i = 0;

         int number1 = 0;
         int number2 = 0;
         int number3 = 0;



         //Asking for the user to input their name and storing it in hold1 string.
         Console.WriteLine("What is your name? ");
         string name = Console.ReadLine();

         //Welcoming the user to my program.
         Console.WriteLine($"Welcome to my number sorter {name} \n");

         //Asking for user to input their first number.
         //Storing their number in an integer value (number1).
         Console.Write("Please enter your first number: ");
         int hold1 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their second number.
         //Storing their number in an integer value (number2).
         Console.Write("\nPlease enter your second number: ");
         int hold2 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their third number.
         //Storing their number in an integer value (number3).
         Console.Write("\nPlease enter your third number: ");
         int hold3 = Convert.ToInt32(Console.ReadLine());

         if ((hold1 < hold2) && (hold1 < hold3))
         {
            if (hold2 < hold3)
            {
               number1 = hold1;
               number2 = hold2;
               number3 = hold3;
            }
            else
            {
               number1 = hold1;
               number2 = hold3;
               number3 = hold2;
            }
         }
         else if ((hold2 < hold1) && (hold2 < hold3))
         {
            if (hold1 < hold3)
            {
               number1 = hold2;
               number2 = hold1;
               number3 = hold3;
            }
            else
            {
               number1 = hold2;
               number2 = hold3;
               number3 = hold1;
            }
         }
         else if ((hold3 < hold1) && (hold3 < hold2))
         {
            if (hold1 < hold2)
            {
               number1 = hold3;
               number2 = hold1;
               number3 = hold2;
            }
            else
            {
               number1 = hold3;
               number2 = hold2;
               number3 = hold1;
            }
         }

         Console.Write($"\n{name} your numbers in order are {number1}, {number2}, " +
                 $"{number3}. ");
      }
   }
}
