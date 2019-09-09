using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuSelection;
            double userInput = 0.0;

            DegreesConversion(userInput);
            Polynomial(userInput);
            Polynomial2(userInput);
            TimeConversion(userInput);
        }

        static double DegreesConversion(double f)
        {
            double c = (5 * (f - 31)) / 9;
            //need to write a line
            "The tempature in Celcus is " + c + " Degrees"
            return c;
        }

        static double Polynomial(double x)
        {
            double y = (3 * Math.Pow(x, 2)) - (7 * x) + 2;
            //need to write a line
            "The value of the polynomial is " + y
            return y;
        }

        static double Polynomial2(double x)
        {
            double y = (4 * Math.Pow(x, 2)) + (3 * x) - 5;
            //need to write a line
            "The value of the polynomial is " + y
            return y;
        }

        static double TimeConversion(double sec)
        {
            double time = sec;
            int hours;
            int minuets;
            int seconds;

            hours = (int)Math.Floor((sec / 60) / 60);
            sec = sec - ((hours * 60) * 60);

            minuets = (int)Math.Floor(sec / 60);
            sec = sec - (minuets * 60);


            (time + " seconds converts to " + hours + " hours " + minuets + " minutes " + sec + " seconds")
            //need to write a line
            return time;
        }



    }
}
