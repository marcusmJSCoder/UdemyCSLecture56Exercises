using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCSLecture56Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Marcus Mayo
             * 5/13/19
             * 
             * #1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
             * If no one likes your post, it doesn't display anything.
             * If only one person likes your post, it displays: [Friend's Name] likes your post.
             * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
             * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
             * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
             */

            //string input;
            //var names = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("Enter different names: ");
            //    input = Console.ReadLine();
            //    names.Add(input);

            //    if (String.IsNullOrWhiteSpace(input))
            //        break;
            //    else if (names.Count() == 1)
            //        Console.WriteLine(names[0] + " likes your post.");
            //    else if (names.Count() == 2)
            //        Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
            //    else
            //        Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count() - 2) + " other people like your post.");
            //}

            /*
             * Marcus Mayo
             * 5/14/19
             *             
             * #2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
             */

            //Console.WriteLine("Enter your name");
            //var nameInput = Console.ReadLine();

            //var nameArray = new char[nameInput.Length];

            //// use a for loop to convert the chars
            //for (var i = nameInput.Length; i > 0; i--)
            //{
            //    nameArray[nameInput.Length - i] = nameInput[i - 1];
            //}
            //    var reversed = new string (nameArray);
            //    Console.WriteLine(reversed);

            /*
             * Marcus Mayo
             * 5/15/19
             * 
             * #3 Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error message and ask the user to re-try.
             * Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
             */

            //Console.WriteLine("Enter 5 numbers");
            //var numberArray = new int[5];

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    var input = Console.ReadLine();
            //    var inputToInteger = Convert.ToInt32(input);
            //    int pos = Array.IndexOf(numberArray, inputToInteger);
            //    if (pos > -1)
            //    {
            //        Console.WriteLine("Number has already been entered, please retry.");
            //        i--;
            //    }
            //    else numberArray[i] = inputToInteger;
            //}

            //for (int x = 0; x < numberArray.Length; x++ )
            //{
            //    Array.Sort(numberArray) ;
            //    Console.Write(numberArray[x] + " ");
            //}

            /*
             * Marcus Mayo
             * 5/16/19
             * 
             * #4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates. Display the unique numbers that the user has entered.
             */

            //var numbers = new List<int>();
            //Console.WriteLine("Enter as many numbers as you'd like, or type \"Quit\" to exit");

            //while (true)
            //{
            //    var input = Console.ReadLine();
            //    if (input.ToLower() == "quit")
            //    {
            //        break;
            //    }
            //    else if (!numbers.Contains(Convert.ToInt32(input)))
            //    {
            //        numbers.Add(Convert.ToInt32(input));
            //    }
            //}
            //Console.Write("List of unique numbers: ");
            //foreach (var number in numbers)
            //{
            //    Console.Write(number + ", ");
            //}


            /*
             * 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
             */


        }
    }
}
