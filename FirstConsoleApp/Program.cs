using System;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            double height;
            double weight;
            string name;
            char gender;
            bool isStudent;

        
            Console.WriteLine("Welcome to the Health Tracker App!");
            Console.WriteLine("Please provide the following details:");


            Console.Write("Enter your name: ");
            string? inputName = Console.ReadLine();
            name = inputName ?? string.Empty;
            Console.WriteLine("Hello, " + name);

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Your height in centimeters: ");
            double heightInCentimeters = Convert.ToDouble(Console.ReadLine());
            height = heightInCentimeters / 100;

            Console.Write("Enter your weight in kg: ");
            weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter your gender (M/F): ");
            string? inputGender = Console.ReadLine();
            gender = char.ToUpper(inputGender?.FirstOrDefault() ?? ' '); 

            Console.Write("Are you a student? (Y/N): ");
            string? inputIsStudent = Console.ReadLine();
            isStudent = inputIsStudent?.Equals("Y", StringComparison.OrdinalIgnoreCase) ?? false;
            Console.WriteLine("Are you a student? " + (isStudent ? "Yes" : "No"));

            Console.WriteLine("Hello, {0}!", name);
            Console.WriteLine("Your age: {0}", age);
            Console.WriteLine("Your height: {0} meters", height);
            Console.WriteLine("Your weight: {0} kilograms", weight);
            Console.WriteLine("Your gender: {0}", gender);
            Console.WriteLine("Are you a student? {0}", isStudent ? "Yes" : "No");

            double heightInFeet = heightInCentimeters / 30.48;
            Console.WriteLine("Your height in feet: " + heightInFeet);

            double bmi = weight / (height * height);
            Console.WriteLine("Your BMI: {0}", bmi);

            if (bmi < 18.5)
            {
                Console.WriteLine("You are underweight.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("You have a healthy weight.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("You are overweight.");
            }
            else
            {
                Console.WriteLine("You are obese.");
            }

        
            MathLibrary.MathHelper mathHelper = new MathLibrary.MathHelper();
            int squareResult = mathHelper.Square(5);
            int squareRootResult = (int)mathHelper.SquareRoot(squareResult);
            Console.WriteLine("Square root of {0} is: {1}", squareResult, squareRootResult);
        }
    }
}