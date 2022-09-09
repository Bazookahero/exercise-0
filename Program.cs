using System.Net.Http.Headers;

namespace exercise_0
{
    internal class Program
    {

        static void RunExerciseOne()
        {
            Console.WriteLine("Please enter your first name");
            string callingName = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            string surName = Console.ReadLine();
            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!",callingName, surName);
        }
        static void RunExerciseTwo()
        {
            string dateYesterday = "2022/09/08";
            string dateToday = "2022/09/09";
            string dateTomorrow = "2022/09/10";
            Console.WriteLine("Today's date is {0}", dateToday);
            Console.WriteLine("Tomorrow's date is {0}", dateTomorrow);
            Console.WriteLine("Yesterday's date was {0}", dateYesterday);
        }
        static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("{0} {1}",firstName,lastName);

        }
        static void RunExerciseFour()
        {
            string str = "The quick fox jumped Over the DOG";
            string strTwo;
            strTwo = str.ToLower();
            strTwo = strTwo.Replace("quick", "brown");
            strTwo = strTwo.Remove(strTwo.Length-3);
            strTwo = strTwo.Insert(strTwo.Length, "lazy dog");
            strTwo = strTwo.Remove(0, 1);
            strTwo = strTwo.Insert(0, "T");


            Console.WriteLine(strTwo);
        }
        static void RunExerciseFive()
        {
            string str = "Arrays are very commin in programming, they look something like: [1,2,3,4,5]";
            //Console.WriteLine(str.IndexOf('2'));
            //Console.WriteLine(str.IndexOf('3'));
            string newStr = str.Remove(68, 4);
            //Console.WriteLine(newStr.IndexOf('5'));
            newStr = newStr.Insert(71, ",6,7,8,9,10");
            Console.WriteLine(newStr);
        }
        static void RunExerciseSix()
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
        static void RunExerciseSeven()
        {
            Console.WriteLine("Please input the circle's radius");
            double circleRadius = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the circle is: " + (Math.PI * (circleRadius*circleRadius)));
            Console.WriteLine("and the volume is: " + ((4 * Math.PI * (Math.Pow(circleRadius, 3))))/3);
        }
        static void RunExerciseEight()
        {
            Console.WriteLine("please input a decimal number");
            double userInput = double.Parse(Console.ReadLine());
            Console.WriteLine("square root: " + Math.Sqrt(userInput) + "\nraised to the power of 2: " + Math.Pow(userInput, 2) + "\nraised to the power of 10: " + Math.Pow(userInput, 10));
        }
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Exercise 1       ".PadLeft(35));
                    Console.Write("Exercise 2       ");
                    Console.Write("Exercise 3       "); 
                    Console.Write("Exercise 4       "); 
                    Console.WriteLine("Exercise 5       ");
                    Console.Write("Exercise 6       ".PadLeft(35));
                    Console.Write("Exercise 7       ");
                    Console.Write("Exercise 8       ");
                    Console.Write("Exercise 9       ");
                    Console.WriteLine("Exercise 10       ");
                    Console.WriteLine("\n\n");
                    Console.Write("Enter exercise number or -1 to exit: ".PadLeft(70));
                    
                    
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ResetColor();

                    switch (assignmentChoice)
                    {
                            case 1:
                                RunExerciseOne();
                            break;
                            case 2: 
                                RunExerciseTwo();
                                break;
                            case 3:
                                RunExerciseThree();
                                break;
                            case 4:
                                RunExerciseFour();
                                break;
                            case 5:
                                RunExerciseFive();
                                break;
                            case 6:
                                RunExerciseSix();
                            break;
                            case 7:
                                RunExerciseSeven();
                            break;
                            case 8:
                                RunExerciseEight();
                            break;
                            case -1:
                                keepAlive = false;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Please use a valid number");
                                break;

                    }
                    Console.ResetColor();
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();


                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please use a valid number");
                    Console.ResetColor();
                }
            }
        }
    }
}