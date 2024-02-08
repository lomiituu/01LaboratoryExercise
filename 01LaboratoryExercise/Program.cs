using System;

namespace _01LaboratoryExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter number of course/s: ");
            int course;
            course = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the price of your favorite book: ");
            double book;
            book = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hi! Your name is " + name);
            Console.WriteLine("Total number of enrolled courses: " + course);
            Console.WriteLine("Price of your favorite book: " + book);

        }
    }
}