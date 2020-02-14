//****************************************************************************
//****************************************************************************
//
// OMIT
// CSCI 1301CD
// Programming Assignment 1
// 01/29/2020
//
// Sorter.cs
//
//***************************************************************************
//***************************************************************************

using System;

namespace Programming_Assignment_1
{
   class SorterThree
   {
      static void Main(string[] args)
      {
         //Initializing 'i' you will see more how this is used below.'
         int i = 0;

         int number1 = 0;
         int number2 = 0;
         int number3 = 0;
         int hold1 = 0;
         int hold2 = 0;
         int hold3 = 0;
         int hold4 = 0;

         //Asking for the user to input their name and storing it in hold1 string.
         Console.WriteLine("What is your name? ");
         string name = Console.ReadLine();

         //Welcoming the user to my program.
         Console.WriteLine($"Welcome to my number sorter {name} \n");

         //Asking for user to input their first number.
         //Storing their number in an integer value (number1).
         Console.Write("Please enter your first number: ");
         hold1 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their second number.
         //Storing their number in an integer value (number2).
         Console.Write("\nPlease enter your second number: ");
         hold2 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their third number.
         //Storing their number in an integer value (number3).
         Console.Write("\nPlease enter your third number: ");
         hold3 = Convert.ToInt32(Console.ReadLine());

         if (hold1 > hold2)
         {
            hold4 = hold2;
            hold2 = hold1;
            hold1 = hold4;
         }
         if (hold2 > hold3)
         {
            hold4 = hold3;
            hold3 = hold2;
            hold2 = hold4;
         }
         if (hold1 > hold2)
         {
            hold4 = hold2;
            hold2 = hold1;
            hold1 = hold4;
         }

         number1 = hold1;
         number2 = hold2;
         number3 = hold3;
       
         Console.Write($"\n{name} your numbers in order are {number1}, {number2}, " +
                 $"{number3}. ");
      }
   }
}
