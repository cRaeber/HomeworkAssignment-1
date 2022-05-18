using System;

namespace Homework_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string result;
            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result != "5");

            Console.WriteLine(" Good Bye...");
        }

        //creates the menu where the user will select what function they want to run or if they want to exit the program
        public static string DisplayMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Homework 1");
            Console.WriteLine("");
            Console.WriteLine("Hit [1] to run ConvertDegrees.");
            Console.WriteLine("Hit [2] to run ComputePolyOne.");
            Console.WriteLine("Hit [3] to run ComputePolyTwo.");
            Console.WriteLine("Hit [4] to run ConvertSeconds.");

            Console.WriteLine("");
            Console.WriteLine("Hit [5]: Exit;");
            Console.WriteLine("");
            Console.WriteLine("");

            var result = Console.ReadLine();
            return result;
        }

        private static bool Run(string exeArg)
        {

            switch (exeArg.ToLower())
            {
                case "1":
                    DegreesConversion();
                    return true;
                case "2":
                    Polynomial(exeArg, 2);
                    return true;
                case "3":
                    Polynomial(exeArg, 3);
                    return true;
                case "4":
                    TimeConversion();
                    return true;
                case "5":
                    Console.WriteLine("Exiting the Program!");
                    return true;
                default:
                    Console.WriteLine("Please enter a value between 1-5");
                    return true;
            }
        }

        public static string DegreesConversion()
        {
            Console.WriteLine("Enter the temerature you want to convert:");
            double f = Double.Parse(Console.ReadLine());
            double c = (5 * (f - 31)) / 9;
            string answer = ("The tempature in Celcus is " + c + " Degrees");
            return answer;
        }

        //use an if to send it through the right poly function 
        static string Polynomial(string arg, int form)
        {
            Console.WriteLine("Enter a value for x:");
            double x = Double.Parse(Console.ReadLine());

            if (form == 2)
            {
                double y = (3 * Math.Pow(x, 2)) - (7 * x) + 2;
                string answer = ("The value of the polynomial is " + y);
                return answer;
            }
            else
            {
                double y = (4 * Math.Pow(x, 2)) + (3* x) - 5;
                string answer = ("The value of the polynomial is " + y);
                return answer;
            }                
        }       

        static string TimeConversion()
        {
            Console.WriteLine("Enter the number of seconds:");
            var time = Console.ReadLine();
            double sec = Double.Parse(time);
            int hours;
            int minuets;

            hours = (int)Math.Floor((sec / 60) / 60);
            sec = sec - ((hours * 60) * 60);

            minuets = (int)Math.Floor(sec / 60);
            sec = sec - (minuets * 60);

            string answer = (time + " seconds converts to " + hours + " hours " + minuets + " minutes " + sec + " seconds");
            return answer;
        }
    }
}
