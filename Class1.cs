using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

public class Class1
{
    public static void RunExerciseOne()
    {
        Console.WriteLine("Please enter your first name");
        string callingName = Console.ReadLine();
        Console.WriteLine("Please enter your last name");
        string surName = Console.ReadLine();
        Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", callingName, surName);
    }
    public static void RunExerciseTwo()
    {
        Console.WriteLine("Today's date is " + DateTime.Now);
    }
    public static void RunExerciseThree()
    {
        Console.Write("Enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("{0} {1}", firstName, lastName);

    }
    public static void RunExerciseFour()
    {
        string str = "The quick fox jumped Over the DOG";
        string strTwo;
        strTwo = str.ToLower();
        strTwo = strTwo.Replace("quick", "brown");
        strTwo = strTwo.Remove(strTwo.Length - 3);
        strTwo = strTwo.Insert(strTwo.Length, "lazy dog");
        strTwo = strTwo.Remove(0, 1);
        strTwo = strTwo.Insert(0, "T");


        Console.WriteLine(str + " -> " + strTwo);
    }
    public static void RunExerciseFive()
    {
        string str = "Arrays are very commin in programming, they look something like: [1,2,3,4,5]";
        //Console.WriteLine(str.IndexOf('2'));
        //Console.WriteLine(str.IndexOf('3'));
        string newStr = str.Remove(68, 4);
        //Console.WriteLine(newStr.IndexOf('5'));
        newStr = newStr.Insert(71, ",6,7,8,9,10");
        Console.WriteLine(newStr);
    }
    public static void RunExerciseSix()
    {
        Console.WriteLine("please input two numbers, one at a time");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        if (num1 > num2)
        {
            Console.WriteLine("the biggest number is {0} and the smallest is {1}", num1, num2);
        }
        else if (num1 < num2)
        {
            Console.WriteLine("the biggest number is {0} and the smallest is {1}", num1, num2);
        }
        else
        {
            Console.WriteLine("they're both equally big.");
        }
        Console.WriteLine("the difference is " + (num1 - num2));
        Console.WriteLine("the sum is " + (num1 + num2));
        Console.WriteLine("the product is " + (num1 * num2));
        Console.WriteLine("the ratio is " + (num1 / num2) + " and the rest is " + (num1 % num2));
    }
    public static void RunExerciseSeven()
    {
        Console.WriteLine("Please input the circle's radius");
        double circleRadius = double.Parse(Console.ReadLine());
        Console.WriteLine("The area of the circle is: " + (Math.PI * (circleRadius * circleRadius)));
        Console.WriteLine("and the volume is: " + ((4 * Math.PI * (Math.Pow(circleRadius, 3)))) / 3);
    }
    public static void RunExerciseEight()
    {
        Console.WriteLine("please input a decimal number");
        double userInput = double.Parse(Console.ReadLine());
        Console.WriteLine("square root: " + Math.Sqrt(userInput) + "\nraised to the power of 2: " + Math.Pow(userInput, 2) + "\nraised to the power of 10: " + Math.Pow(userInput, 10));
    }
    public static void RunExerciseNine()
    {
        Console.WriteLine("Hello! What's your name?");
        string userName = Console.ReadLine();
        Console.WriteLine("what's your birthyear?");
        int birthYear = int.Parse(Console.ReadLine());
        int userAge = DateTime.Now.Year - birthYear;
        if (userAge >= 18)
        {
            Console.WriteLine("do you want to order a beer? y/n");
            char userSelection = char.Parse(Console.ReadLine());

            if (userSelection == 'n')
            {
                Console.WriteLine("Do you want a coke?");
                userSelection = char.Parse(Console.ReadLine());

                if (userSelection == 'n')
                {
                    Console.WriteLine("no other options are available");
                }


            }
            if (userSelection == 'y')
            {
                Console.WriteLine("The beverage has been served");
            }


        }
        if (userAge < 18)
        {
            Console.WriteLine("Do you want a coke?");
            char userSelectionTwo = char.Parse(Console.ReadLine());
            if (userSelectionTwo == 'y')
            {
                Console.WriteLine("The beverage has been served");
            }
            else
            {
                Console.WriteLine("no other options are available");
            }

        }
    }
    public static void RunExerciseTen()
    {
        Console.WriteLine("Please choose:");
        Console.WriteLine("1. division");
        Console.WriteLine("2. exercise 4");
        Console.WriteLine("3. change colour");
        int userInput = int.Parse(Console.ReadLine());
        switch (userInput)
        {
            case 1:
                Console.WriteLine("please insert two numbers, one at a time");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (num2 != 0)
                {
                    Console.WriteLine("the result is: " + num1 / num2);
                }
                else
                {
                    Console.WriteLine("there was an error");
                }
                break;
            case 2:
                RunExerciseFour();
                break;
            case 3:
                Console.WriteLine("1. DarkBlue");
                Console.WriteLine("2. DarkCyan");
                Console.WriteLine("3. Red");
                Console.WriteLine("4. Quit");
                int menuNum = int.Parse(Console.ReadLine());

                while (menuNum != 4)
                {
                    if (menuNum == 1)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("DarkBlue");
                        break;
                    }
                    if (menuNum == 2)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("DarkCyan");
                        break;
                    }
                    if (menuNum == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red");
                        break;
                    }
                }
                break;

        }
    }
    public static void RunExerciseEleven()
    {
        Console.WriteLine("please input an int greater than 0");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {

            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(i);


            }
            Console.WriteLine("--------------------");
            for (int x = num; x >= 0; x--)
            {
                if (x % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine(x);

            }

        }
        else
        {
            Console.WriteLine("please use an int over 0");
        }
    }
    public static void RunExerciseTwelve()
    {
        Console.WriteLine("multiplication table");
        for (int i = 1; i <= 10; i++)
        {
            for (int x = 1; x <= 10; x++)
            {
                Console.Write(" " + x * i);

            }
            Console.WriteLine("\t");
        }
    }
    public static void RunExerciseThirteen()
    {
        Random rnd = new Random();
        int rndNum = rnd.Next(1, 500);
        int UserGuess;
        int numberOfGuesses = 0;
        bool reset = false;


        do
        {
            Console.Clear();
            Console.WriteLine("guess a random number between 1 and 500. Type -1 to exit");
            UserGuess = int.Parse(Console.ReadLine());
            if (UserGuess == rndNum)
            {
                numberOfGuesses++;
                Console.WriteLine("Congratulations you won!\n numer of guesses: {0}", numberOfGuesses);
                reset = true;
            }
            if (UserGuess > rndNum)
            {
                Console.WriteLine("your guess was too big");

            }
            if (UserGuess < rndNum && UserGuess != -1)
            {
                Console.WriteLine("your guess was too small");
            }
            Console.ReadKey();
            numberOfGuesses++;
        } while (reset == false && UserGuess != -1);
    }
    public static void RunExerciseFourteen()
    {

        List<int> intList = new List<int>();
        int userInput = 0;
        while (userInput != -1)
        {
            Console.WriteLine("please enter numbers to add together or -1 to end the program: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != -1)
            {
                intList.Add(userInput);
            }
        }
        double average = intList.Average();
        int sum = intList.Sum();
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
    public static void RunExerciseFifteen()
    {
        List<string> stringlist = new List<string>();
        Console.WriteLine("please type a positive number");
        int userNum = int.Parse(Console.ReadLine());
        for (int i = userNum; i > 0; i--)
        {
            if (userNum % i == 0)
            {
                //i.ToString().Remove(0, userNum.ToString().Length);
                stringlist.Add(i.ToString());
            }
        }
        stringlist.Remove(userNum.ToString());
        foreach (string str in stringlist)
        {
            Console.Write("your number is divisible by this number: {0} \n", str);
        }
        int x;
        int sum;
        for (int n = 0; n <= 500; n++)
        {
            x = 1;
            sum = 0;
            while (x < n)
            {
                if (n % x == 0)
                    sum = sum + x;
                x++;
            }
            if (sum == n)
                Console.Write("perfect numbers: {0} ", n);
        }
        Console.Write("\n");
    }
    public static void RunExerciseSixteen()
    {
        Console.Write("enter hos many fibonacci sequences you want: ");
        int userInput = int.Parse(Console.ReadLine());
        int z = 1;
        int x = 0;
        int y = 1;
        Console.Write("0, 1, ");
        for (int i = 2; i < userInput; i++)
        {
            y = x + z;
            Console.Write("{0}, ", y);
            x = z;
            z = y;
        }
    }
    public static void RunExerciseSeventeen()
    {
        Console.Write("Enter a word to check if it's a palindrome: ");
        string userInput = Console.ReadLine();

        int index = userInput.IndexOf(' ');
        string userTrim = userInput.Trim();
        char[] trimmedString = userTrim.ToCharArray().Where(c => !Char.IsWhiteSpace(c)).ToArray();
        char[] reverseString = trimmedString;
        Array.Reverse(reverseString);
        string reversedString = "";
        string trimString = "";
        for (int i = 0; i < reverseString.Length; i++)
        {
            reversedString += reverseString[i];
        }
        for (int x = trimmedString.Length - 1; x >= 0; x--)
        {
            trimString += trimmedString[x];
        }

        if (trimString == reversedString)
        {
            Console.WriteLine("your word is a palindrome!");
        }
        else
        {
            Console.WriteLine("your word is not a palindrome!");
        }
    }
    public static void RunExerciseEighteen()
    {
        Random rnd = new Random();
        int[] intArray = new int[10];
        double[] doubleArray = new double[10];
        for (int i = 0; i < intArray.Length; i++)
        {
            doubleArray[i] = 1;
            intArray[i] = rnd.Next();
            foreach (int n in intArray)
            {
                doubleArray[i] = doubleArray[i] / intArray[i];
            }
            Console.WriteLine(doubleArray[i]);
        }
    }
    public static void RunExerciseNineteen()
    {
        int payAntal = 0;
        int payMod = 0;
        int[] change = { 1000, 500, 100, 50, 20, 10, 1 };
        Random rnd = new Random();
        int price = rnd.Next(100, 5000);
        int payChange = 0;
        Console.WriteLine("the price is: {0}", price);
        Console.WriteLine("how much do you hand the cashier?");
        int pay = int.Parse(Console.ReadLine());
        if (pay < price)
        {
            Console.WriteLine("that is not enough.");
        }
        if (pay == price)
        {
            Console.WriteLine("thank you very much");
        }
        if (pay > price)
        {
            
            
                payChange = pay - price;
            while (payChange>0)
                if (payChange >= 1000)
                {
                    payAntal = payChange / change[0];
                    Console.WriteLine("tusenlappar: " + payAntal);
                    payChange = payChange - (payAntal * change[0]);

                }
                else if (payChange >= 500)
                {
                    payAntal = payChange / change[1];
                    Console.WriteLine("femhundralappar: " + payChange / change[1]);
                    payMod = payChange % change[1];
                    
                    payChange = payChange - (payAntal * change[1]);
                    
                    

                }
                else if (payChange >= 100)
                {
                    payAntal = payChange / change[2];
                    Console.WriteLine("hundralappar: " + payChange / change[2]);
                 
                    payChange = payChange - (payAntal * change[2]);
                    
                }
                else if (payChange >= 50)
                {
                    payAntal = payChange / change[3];
                    Console.WriteLine("femtiolappar: " + payChange / change[3]);
         
                    payChange = payChange - (payAntal * change[3]);
                    
                }
                else if (payChange >= 20)
                {
                    payAntal = payChange / change[4];
                    Console.WriteLine("tjugolappar: " + payChange / change[4]);
            
                    payChange = payChange - (payAntal * change[4]);
                   
                }
                else if (payChange >= 10)
                {
                    payAntal = payChange / change[5];
                    Console.WriteLine("tior: " + payChange / change[5]);
            
                    payChange = payChange - (payAntal * change[5]);
                   
                }
                else if (payChange >= 1)
                {
                    payAntal = payChange / change[6];
                    Console.WriteLine("enkronor: " + payChange / change[6]);
              
                    payChange = payChange - (payAntal * change[6]);
                    
                }

            
        }
    }
}
