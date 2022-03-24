using System;

namespace Metoder_Lette_1_3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int talA = 66;
            int talB = 13;

            // Adding a to b
            int addResult = AddNumbers(talA, talB);
            Console.WriteLine(addResult);



            double devideResult = DevideNumbers(talA,talB);
            Console.WriteLine(devideResult);

            //Rounding the devided result to get how many times a can be devided with b
            double roundResult = RoundNumber(talA,talB);
            Console.WriteLine("Number A can be devided with number B  "+roundResult+" Times");


            //Lifting a with the power of b
            double liftedResult = LiftedNumbers(talA, talB);
            Console.WriteLine(liftedResult);

            double pytaghorasResult = Pytaghoras(talA, talB);
            Console.WriteLine(pytaghorasResult);

            //Checking which number is the biggest
            if (talA > talB)
            {
                Console.WriteLine("Number A is bigger than number B");
            }
            else if (talA < talB)
            {
                Console.WriteLine("Number B is bigger than number A");
            }
            else
            {
                Console.WriteLine("The 2 numbers are equally big");
            }

            Console.WriteLine("Put in your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Put in your age: ");
            int age = int.Parse(Console.ReadLine());

            string ageCheckResult = AgeCheck(name, age);
            Console.WriteLine(ageCheckResult);


        }
        //Add numbers
        static  int AddNumbers(int a, int b)
        {
            
            return a + b;
        }
        //Devide Numbers
        static double DevideNumbers(int a, int b)
        {
            return Math.Round((float)a / b,2);
        }
        //Round Numbers
        static double RoundNumber(int a, int b)
        {
            return a / b;
        }
        //Lift Numbers
        static double LiftedNumbers(int a, int b)
        {
            return Math.Round(Math.Pow(a, b),2);
        }

        static double Pytaghoras(int a, int b)
        {
            double powA = Math.Pow(a, 2);
            double powB = Math.Pow(b, 2);
            double powC = powA + powB;
            double C = Math.Round(Math.Sqrt(powC),2);
            return C;
        }


        static string AgeCheck(string name, int age)
        {
            if (age <= 3)
            {
                return name +", du må gå med ble";
            }
            else if (age > 3 && age <= 15)
            {
                return name + ", du må ingenting";
            }
            else if (age > 15 && age < 18)
            {
                return name + ", du må drikke";
            }
            else if (age >= 18)
            {
                return name + ", du må stemme og køre bil";
            }
            else
            {

            return "An error accured, either name: " + name + " or age " + age + "is wrong";
            }

        }
    }
}
