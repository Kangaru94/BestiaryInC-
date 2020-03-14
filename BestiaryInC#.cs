using System;
using System.Media;

namespace Official_Bestiary
{
    class Program
    {
        static void Main()
        {
            Hello();
            SwitchCase();
            
        }

        static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        static void SwitchCase()
        {
            //string choice = "A";
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "A":
                case "a":
                    ChoiceA();
                    break;

                case "B":
                case "b":
                    ChoiceB();
                    break;
            }

        }

        static void ChoiceA()
        {
            Console.WriteLine("Chose to attack");
        }

        static void ChoiceB()
        {
            Console.WriteLine("Chose to block");
        }
    }
}
