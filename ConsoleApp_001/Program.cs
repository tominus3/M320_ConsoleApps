namespace ConsoleApp_001
{
    internal class MyMath
    {
        // Calculates the greatest common divisor of 2 numbers and gives it back as an int
        static int Calc_ggt(int number1, int number2)
        {
            int temp = 0;

            while (number2 != 0)
            {
                temp = number1 % number2;
                number1 = number2;
                number2 = temp;
            }
            return number1;
        }

        // Calculates the greatest common divisor of 2 numbers recursive and gives it back as an int
        static int Calc_ggt_r(int number1, int number2)
        {
            if (number2 == 0)
            {
                return number1;
            }
            else
            {
                return Calc_ggt(number1, number2);
            }
        }

        // Calculates the lowest common divisor of 2 numbers and gives it back as an int
        static int Calc_kgV(int number1, int number2)
        {
            int ggt = Calc_ggt_r(number1, number2);
            return number1 * number2 / ggt;
        }

        // Asks for a whole Number above zero and gives it back as an int
        static int ReadInt()
        {
            int number = 0;
            bool valid = false;

            while (!valid)
            {
                Console.Write("Bitte geben Sie eine positive und ganze Zahl ein: ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    valid = true;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }
            return number;
        }

        // Shows the gcd or lcd based on the user input
        static void ShowResult(int number1, int number2)
        {
            string? eingabe = "";
            bool valid = false;

            while (!valid)
            {
                Console.WriteLine("Was wollen Sie von den Nummern haben (ggt/kgV)?: ");
                eingabe = Console.ReadLine();

                if (eingabe != null)
                {
                    eingabe = eingabe.ToLower().Trim();
                    if (eingabe == "ggt" || eingabe == "kgv")
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe...");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe...");
                    Thread.Sleep(1000);
                    Console.Clear();
                }
            }

            if (eingabe == "ggt")
            {
                Console.WriteLine($"ggt von {number1} und {number2} ist {Calc_ggt_r(number1, number2)}");
            }
            else if (eingabe == "kgv")
            {
                Console.WriteLine($"kgV von {number1} und {number2} ist {Calc_kgV(number1, number2)}");
            }
        }

        // Gives back the average value of an array
        static float ArrayAverage(int[] array)
        {
            float average = 0;
            int sum = 0;

            foreach(int number in array)
            {
                sum += number;
            }

            average = (float)sum / array.Length;
            return average;
        }

        // Gives back the lowest value of an array
        static int ArrayLowestNumber(int[] array)
        {
            int lowest = 0;
            lowest = array[0];
            foreach(int item in array)
            {
                if (lowest > item)
                {
                    lowest = item;
                }
            }
            return lowest;
        }

        // Gives back the highest value of an array
        static int ArrayHighestNumber(int[] array)
        {
            int highest = 0;
            highest = array[0];
            foreach (int item in array)
            {
                if (highest < item)
                {
                    highest = item;
                }
            }
            return highest;
        }

        // Swaps the the Input numbers
        static void Swap(ref int number1, ref int number2)
        {
            int temp = number1;
            number1 = number2;
            number2 = temp;
        }

        // Main Programm Loop
        static void Main()
        {
            // Decleration
            bool end = false;
            int number1 = 0;
            int number2 = 0;
            string? input = "";
            bool valid = false;

            while (!end)
            {
                number1 = ReadInt();
                number2 = ReadInt();

                ShowResult(number1, number2);

                valid = false;

                while (!valid)
                {
                    Console.WriteLine("Do you want to go again (j/n)?");
                    input = Console.ReadLine();

                    if (input != null)
                    {
                        input = input.ToLower().Trim();
                        if (input == "n")
                        {
                            end = true;
                        }
                        else if (input == "j")
                        {
                            valid = true;
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Ungültige Eingabe...");
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe...");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
            }
        }
    }
}
