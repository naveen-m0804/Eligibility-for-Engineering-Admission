using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter marks obtained in Maths:");
        int mathsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks obtained in Physics:");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter marks obtained in Chemistry:");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = mathsMarks + physicsMarks + chemistryMarks;

        if (mathsMarks >= 65 && physicsMarks >= 55 && chemistryMarks >= 50 && (totalMarks >= 180 || (mathsMarks + physicsMarks) >= 140))
        {
            Console.WriteLine("Congratulations! You are eligible for admission to the engineering course.");
        }
        else
        {
            Console.WriteLine("You are not eligible for admission to the engineering course.");
        }
    }
}
