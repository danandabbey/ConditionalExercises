﻿using System;

namespace ConditionalExercises
{
    internal class Conditionals
    {

        public static void Main()
        {
            
        }

        /// Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)

        public static void Exercise1()
        {
            Console.WriteLine("Enter a number between 1 and 10");
            var input = Convert.ToInt32(Console.ReadLine());
            if (input >= 1 && input <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
    
        }

        /// Write a program which takes two numbers from the console and displays the maximum of the two.

        public static void Exercise2()
        {
            Console.WriteLine("Enter 2 numbers seperated by a comma");
            var input = Console.ReadLine();
            var i = input.Split(',');
            var first = Convert.ToInt32(i[0]);
            var second = Convert.ToInt32(i[1]); 
            var larger = Math.Max(first, second);
            var smaller = Math.Min(first, second);
            var output = $"{larger} is larger than {smaller}";
            Console.WriteLine(output);
        }

        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait.

        public static void Exercise3()
        {
            Console.WriteLine("Enter the width of an image");
            var width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height of an image");
            var height = Convert.ToDouble(Console.ReadLine());
            if (width > height)
            {
                Console.WriteLine("That picture is landscape");
            }
            else if (width < height)
            {
                Console.WriteLine("That picture is portrait");
            }
        }

        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
        /// the console. If the number of demerit points is above 12, the program should display License Suspended.

        public static void Exercise4()
        {
            Console.WriteLine("Enter the Speed Limit");
            var limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the car's speed");
            var speed = Convert.ToInt32(Console.ReadLine());

            if (speed <= limit)
            {
                Console.WriteLine("The driver is following the posted speed limit.");
            }
            else if(speed > limit)
            {
                var speedOver = speed - limit;
                var points = speedOver / 5;
                if (points >= 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit Points: " + points);

                }
            }
        }
    }
}