using System;

namespace Task9ExitControl
{
    internal class Program
    {
        static void Main()
        {
            string inputLine = "";
            string exitCommand = "exit";

            while (inputLine != exitCommand)
            {
                Console.WriteLine("У попа была собака, он ее любил.");
                Console.WriteLine("Она съела кусок мяса, он ее убил!");
                Console.WriteLine("В землю закопал, надпись написал, что:\n");

                Console.Write("Для выхода введите " + exitCommand + " или нажмите Enter, чтобы продолжить: ");
                inputLine = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}