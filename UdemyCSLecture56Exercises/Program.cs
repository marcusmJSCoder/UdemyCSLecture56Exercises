﻿using System;
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
             * #1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
             * If no one likes your post, it doesn't display anything.
             * If only one person likes your post, it displays: [Friend's Name] likes your post.
             * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
             * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
             * Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
             */

            string input;
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Enter different names: ");
                input = Console.ReadLine();
                names.Add(input);

                if (String.IsNullOrWhiteSpace(input))
                    break;
                else if (names.Count() == 1)
                    Console.WriteLine(names[0] + " likes your post.");
                else if (names.Count() == 2)
                    Console.WriteLine(names[0] + " and " + names[1] + " like your post.");
                else
                    Console.WriteLine(names[0] + ", " + names[1] + " and " + (names.Count() - 2) + " other people like your post.");
            } 
        }
    }
}
