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
using System.Collections.Generic;

namespace Programming_Assignment_1
{
   class Sorter
   {
      static void Main(string[] args)
      {
         //Initializing 'i' you will see more how this is used below.'
         int i = 0;

         //Asking for the user to input their name and storing it in a string.
         Console.WriteLine("What is your name? ");
         string name = Console.ReadLine();

         //Welcoming the user to my program.
         Console.WriteLine($"Welcome to my number sorter {name} \n");

         //Asking for user to input their first number.
         //Storing their number in an integer value (number1).
         Console.Write("Please enter your first number: ");
         int number1 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their second number.
         //Storing their number in an integer value (number2).
         Console.Write("\nPlease enter your second number: ");
         int number2 = Convert.ToInt32(Console.ReadLine());

         //Asking for user to input their third number.
         //Storing their number in an integer value (number3).
         Console.Write("\nPlease enter your third number: ");
         int number3 = Convert.ToInt32(Console.ReadLine());

         //Storing all inputed numbers into a list.
         List<int> list = new List<int> { number1, number2, number3};
         //Sorting the list with the numbers inside.
         list.Sort();

         Console.Write($"\n{name} your numbers in order are ");

         foreach (int x in list)
         {
            Console.Write(x);

            //Checking for the value of 'i'
            if(i != 2)
            {
               //If 'i' is not equal to 2 then it will print out a comma and a space.
               //This is to separate the numbers.
               Console.Write(", ");
               //The program will then iterate 'i' by 1.
               i++;
            }
         }
         Console.Write(".");
      }
   }
}
