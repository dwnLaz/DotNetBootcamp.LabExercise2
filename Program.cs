using System;

namespace CSharp.LabExercise2
{
    public class Lasagna
    {
        public int ExpectedMinutesInOven()
        {
            return 40;
        }
        public int RemainingMinutesInOven(int actualTime)
        {
            int actualOvenTime = 40 - actualTime;
            return actualOvenTime;
        }
        public int PreparationTimeInMinutes(int addedLayers)
        {
            int addedLayerTime = 2 * addedLayers;
            return addedLayerTime;
        }
        public int ElapsedTimeinMinutes(int addedLayers, int actualTime)
        {
            int elapsedOvenTime = actualTime + (2 * addedLayers);
            return elapsedOvenTime;
        }
    }
    internal class Program
    {
        static void Number1()
        {
            string[] inputArrayNumbers = new string[5];
            int index = 0;
            do
            {
                while (true)
                {
                    for (index = 0; index < inputArrayNumbers.Length;)
                    {
                        bool isInputNumberExisting = false;
                        Console.Write("Enter number: ");
                        string inputNumber = Console.ReadLine();

                        if (Convert.ToInt32(inputNumber) <= 100 && Convert.ToInt32(inputNumber) >= 10)
                        {
                            foreach (string inputArrayNumber in inputArrayNumbers)
                            {
                                if (inputNumber == inputArrayNumber)
                                {
                                    isInputNumberExisting = true;
                                }
                            }
                            if (isInputNumberExisting == false)
                            {
                                inputArrayNumbers[index] = inputNumber;
                                foreach (string inputArrayNumber in inputArrayNumbers)
                                {
                                    Console.Write("{0} ", inputArrayNumber);
                                }
                                Console.WriteLine();
                                index++;
                            }
                            else
                            {
                                Console.WriteLine("{0} has already been entered.", inputNumber);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Number must be between 10 and 100");
                            continue;
                        }
                    }
                    break;
                }
            }while (index < inputArrayNumbers.Length);

            Console.Write("\nBack to Main Menu?\n(y to continue/any key to exit): ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
        static void Number2()
        {
            Lasagna lasagna = new Lasagna();
            Console.WriteLine("Expected Time of the Lasagna in the Oven (Minutes): {0}\n", lasagna.ExpectedMinutesInOven());

            while (true)
            {
                Console.Write("Enter Actual Minutes the Lasagna in the Oven: ");
                int actualTime = Convert.ToInt32(Console.ReadLine());
                if (actualTime <= 40 && actualTime >= 0)
                {
                    Console.WriteLine("Remaining Time of the Lasagna in the Oven (Minutes): {0}\n", lasagna.RemainingMinutesInOven(actualTime));
                    while (true)
                    {
                        Console.Write("Enter Number of Layers: ");
                        int addedLayers = Convert.ToInt32(Console.ReadLine());
                        if (addedLayers >= 0)
                        {
                            Console.WriteLine("Expected Time of the Layer you added in the Lasagna (Minutes): {0}\n", lasagna.PreparationTimeInMinutes(addedLayers));

                            Console.WriteLine("Total Elapsed Time in Minutes (Actual Oven Time + Added Layer Time): {0}", lasagna.ElapsedTimeinMinutes(addedLayers, actualTime));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input (whole numbers only)\n");
                            continue;
                        }
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Please Input a valid Actual Time (0 - 40)\n");
                    continue;
                }
            }

            Console.Write("\nBack to Main Menu?\n(y to continue/any key to exit): ");
            string choice = Console.ReadLine();
            if (choice == "y" || choice == "Y")
            {
                Console.Clear();
                Main();
            }
            else
            {
                Environment.Exit(-1);
            }
        }
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Select Execise");
                Console.WriteLine("[1] - Exercise No. 1");
                Console.WriteLine("[2] - Exercise No. 2");
                Console.WriteLine("[3] - Exit");
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Number1();
                        break;
                    case "2":
                        Console.Clear();
                        Number2();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Thank you");
                        Environment.Exit(-1);
                        break;
                    default:
                        Console.WriteLine("\nInvalid choice!\nReturning to Menu...");
                        System.Threading.Thread.Sleep(2000);
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
