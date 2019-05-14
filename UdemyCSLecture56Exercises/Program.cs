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
             * 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
             */

            Console.WriteLine("Enter your name");
            var nameInput = Console.ReadLine();

            var nameArray = new char[nameInput.Length];
           
            // use a for loop to convert the chars



            Array.Reverse(nameArray);

            foreach(char character in nameArray)
            {
                Console.WriteLine(character);
            }
            
        }
    }
}
