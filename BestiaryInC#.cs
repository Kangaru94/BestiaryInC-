using System;

namespace Console_Bestiary
{
    class Program
    {
        static void Main()
        {
            Hello();
            switchCase();
        }

        static void Hello()
        {
            Console.WriteLine("Hello World!");
        }

        static void switchCase()
        {
            //string choice = "A";
            string choice = Console.ReadLine();

            string chosen = " ";

            switch (choice)
            {
                case "A":
                case "a":
                    chosen = "You chose to attack";
                    break;

                case "B":
                case "b":
                    chosen = "You chose to block";
                    break;
            }

            Console.WriteLine(chosen);
            
        }
    }
}
