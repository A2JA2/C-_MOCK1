using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            string restart;
            do
            {
                Console.WriteLine("Input your weight in kg");
                int WeightKg = Convert.ToInt32(Console.ReadLine()); // user weight in kg input


                if (WeightKg < 30 || WeightKg > 250)
                {
                    Console.WriteLine("Your weight doesn't meet the gym's memvership profile");
                }
                else
                {
                    Console.WriteLine("Input your height in cm");
                }

                int HeightCm = Convert.ToInt32(Console.ReadLine()); // user height in cm input
                if (HeightCm < 120 || HeightCm > 210)
                {
                    Console.WriteLine("your height doesn’t meet the gym’s membership profile");
                }
                else
                {
                    Console.WriteLine("Input your age");
                }

                int Age = Convert.ToInt32(Console.ReadLine()); // user age in year input
                if (Age < 14 || Age > 100)
                {
                    Console.WriteLine("your age doesn’t meet the gym’s membership profile");
                }
                else
                {
                    Console.WriteLine("What is your gender?");
                }
                string Gender = Console.ReadLine().ToUpper(); // user gender input
                if (Gender == "male")
                {
                    double BMR = 88.362 + (13.397 * WeightKg) + (4.799 * HeightCm) - (5.677 * Age);
                    Console.WriteLine($"Your BMR is {BMR}");
                    Console.WriteLine("\nselect your level of exercise using its number: 1. Little to no exercise, 2. Light exercise (1-3 days per week), 3. Moderate exercise (3-5 days per week), 4. Heavy exercise (6-7 days per week), 5. Very heavy exercise (twice per day, extra heavy workouts)");
                    int LevelOfExercise = Convert.ToInt32(Console.ReadLine()); // user picks a number that repesents their level of excersie

                    if (LevelOfExercise == 1)
                    {
                        Double DailyIntake = BMR * 1.2;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 2)
                    {
                        Double DailyIntake = BMR * 1.375;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 3)
                    {
                        double DailyIntake = BMR * 1.55;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 4)
                    {
                        double DailyIntake = BMR * 1.725;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 5)
                    {      
                        double DailyIntake = BMR * 1.9;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    
                }
                else
                {
                    double BMR = 447.593 + (9.247 * WeightKg) + (3.098 * HeightCm) - (4.330 * Age);
                    Console.WriteLine($"\nYour BMR is {BMR}");
                    Console.WriteLine("\nselect your level of exercise using its number: 1. Little to no exercise, 2. Light exercise (1-3 days per week), 3. Moderate exercise (3-5 days per week), 4. Heavy exercise (6-7 days per week), 5. Very heavy exercise (twice per day, extra heavy workouts)");
                    int LevelOfExercise = Convert.ToInt32(Console.ReadLine()); // user picks a number that repesents their level of excersie

                    if (LevelOfExercise == 1)
                    {
                        Double DailyIntake = BMR * 1.2;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 2)
                    {
                        Double DailyIntake = BMR * 1.375;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 3)
                    {
                        double DailyIntake = BMR * 1.55;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 4)
                    {
                        double DailyIntake = BMR * 1.725;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                    else if (LevelOfExercise == 5)
                    {
                        double DailyIntake = BMR * 1.9;
                        Console.WriteLine($"your required daily kilocalories intake is: {DailyIntake}");
                    }
                }
                
                
                double HeightMeters = HeightCm / 100;
                double BMI = WeightKg / (HeightMeters * HeightMeters); // declare the BMI and asign it a value
                Console.WriteLine($"Your BMI is {BMI}");
                if (BMI < 18.5 && BMI > 0)
                {
                    string BMICategory = "Underweight";
                    Console.WriteLine($"Your current BMI category is: {BMICategory}");
                    if (BMICategory == "Normal weight")
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                    else
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                }
                else if (BMI >= 18.5 && BMI <= 24.9)
                {
                    string BMICategory = "Normal weight";
                    Console.WriteLine($"Your current BMI category is: {BMICategory}");
                    if (BMICategory == "Normal weight")
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                    else
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                }
                else if (BMI >= 25 && BMI <= 29.9)
                {
                    string BMICategory = "Overweight";
                    Console.WriteLine($"Your current BMI category is: {BMICategory}");
                    if (BMICategory == "Normal weight")
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                    else
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                }
                else if (BMI >=30)
                {
                    string BMICategory = "Obesity";
                    Console.WriteLine($"Your current BMI category is: {BMICategory}");
                    if (BMICategory == "Normal weight")
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                    else
                    {
                        Console.WriteLine("your target BMI category is Normal weight with a BMI of 22.");
                    }
                }
                    Console.WriteLine("\npress Y to restart. \n press any key to exit."); 
                restart = Console.ReadLine().ToUpper();
            } while (restart == "Y"); // a Do While loop to restart or exit the application

   
            
        }
    }
}
