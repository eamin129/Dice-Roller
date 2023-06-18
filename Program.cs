using System;
using System.Threading.Tasks;
using static System.Console;

namespace DiceRoller
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();

            //Getting input from user
            int numSides = 0;
            int dc = 0;
            bool advantage = false;
            bool disadvantage = false;
            int num1 = 0;
            int num2 = 0;
            int answer = 0;

            Clear();
            WriteLine("Please input the dice you want to use... \n[1] d4 \n[2] d6 \n[3] d8 \n[4] d10 \n[5] d12 \n[6] d20");
            string numSidesinput = Console.ReadLine();

            switch(numSidesinput)
            {
                case "1":
                    numSides = 4;
                    break;

                case "2":
                    numSides = 6;
                    break;

                case "3":
                    numSides = 8;
                    break;

                case "4":
                    numSides = 10;
                    break;

                case "5":
                    numSides = 12;
                    break;

                case "6":
                    numSides = 20;
                    break;
            }

            Clear();
            if (numSides == 20)
            {
                WriteLine("Would you to have a DC? If so, please enter the number (1,20. If not, then enter 0.");
                string dcInput = Console.ReadLine();

                switch (dcInput)
                {
                    case "0":
                        dc = 0;
                        break;
                    case "1":
                        dc = 1;
                        break;
                    case "2":
                        dc = 2;
                        break;
                    case "3":
                        dc = 3;
                        break;
                    case "4":
                        dc = 4;
                        break;
                    case "5":
                        dc = 5;
                        break;
                    case "6":
                        dc = 6;
                        break;
                    case "7":
                        dc = 7;
                        break;
                    case "8":
                        dc = 8;
                        break;
                    case "9":
                        dc = 9;
                        break;
                    case "10":
                        dc = 10;
                        break;
                    case "11":
                        dc = 11;
                        break;
                    case "12":
                        dc = 12;
                        break;
                    case "13":
                        dc = 13;
                        break;
                    case "14":
                        dc = 14;
                        break;
                    case "15":
                        dc = 15;
                        break;
                    case "16":
                        dc = 16;
                        break;
                    case "17":
                        dc = 17;
                        break;
                    case "18":
                        dc = 18;
                        break;
                    case "19":
                        dc = 19;
                        break;
                    case "20":
                        dc = 20;
                        break;
                }

            }
                Clear();
                WriteLine("Would you like to add a number to your roll, if so, please enter it here. If not, enter 0.");
                string addStr = ReadLine();

                int add = Convert.ToInt32(addStr);

            Clear();
            WriteLine("Would you like to have advantage [1], disadvantage [2], or nothing [3]?");
            string advantageStr = ReadLine();

            switch (advantageStr)
            {
                case "1":
                    advantage = true;
                    break;

                case "2":
                    disadvantage = true;
                    break;
                default:
                    advantage = false;
                    disadvantage = false;
                    break;
            }
            //Fake Loading Screen
            Load();
            Clear();

            if (advantage == false && disadvantage == false)
            {
                answer = rand.Next(1, numSides);
            }
            else if (advantage == true)
            {
                num1 = rand.Next(1, numSides);
                num2 = rand.Next(1, numSides);

                if(num1 > num2)
                {
                    answer = num1;
                }
                else if(num2 > num1)
                {
                    answer = num2;
                }
                else
                {
                    answer = num1;
                }
            }
            else if (disadvantage == true)
            {
                num1 = rand.Next(1, numSides);
                num2 = rand.Next(1, numSides);

                if (num1 < num2)
                {
                    answer = num1;
                }
                else if (num2 < num1)
                {
                    answer = num2;
                }
                else
                {
                    answer = num1;
                }
            }


            if (dc == 0)
            {
                if (advantage == false && disadvantage == false)
                {
                    WriteLine("You rolled a " + answer + "!");
                }
                else if (advantage == true)
                {
                    WriteLine("You rolled a " + num1 + " and a " + num2 + "! With advantage, your answer is " + answer + "!");
                }
                else if (disadvantage == true)
                {
                    WriteLine("You rolled a " + num1 + " and a " + num2 + "! With disadvantage, your answer is " + answer + "!");
                }
            }
            else if(dc > 0)
            {
                if(dc > answer)
                {
                    if (advantage == false && disadvantage == false)
                    {
                        WriteLine("You rolled a " + answer + ", and failed the DC of " + dc + "...");
                    }
                    else if (advantage == true || disadvantage == true)
                    {
                        WriteLine("You rolled a " + num1 + " and a " + num2 + "! With a " + answer + ", you failed the DC of " + dc + "...");
                    }
                }
                else if(dc < answer)
                {
                    if (advantage == false && disadvantage == false)
                    {
                        WriteLine("You rolled a " + answer + ", and passed the DC of " + dc + "...");
                    }
                    else if (advantage == true || disadvantage == true)
                    {
                        WriteLine("You rolled a " + num1 + " and a " + num2 + "! With a " + answer + ", you passed the DC of " + dc + "...");
                    }
                }
            }
            WriteLine("Input 'exit' to terminate the program, or input anything else to roll another number");
            string input = ReadLine();
            if(input == "exit")
            {
                System.Environment.Exit(0);
            }
            else
            {
                Main();
            }
        }

        static void Load()
        {
            for (int i = 0; i < 1; i++)
            {
                Clear();
                Write("Rolling");
                Thread.Sleep(500);
                Write(".");
                Thread.Sleep(500);
                Write(".");
                Thread.Sleep(500);
                Write(".");
                Thread.Sleep(500);
            }
        }
    }
}