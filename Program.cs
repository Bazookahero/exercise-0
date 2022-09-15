using System.Net.Http.Headers;


namespace exercise_0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.WriteLine("\n\n\n");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
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
                    Console.Write("Exercise 11      ".PadLeft(35));
                    Console.Write("Exercise 12      ");
                    Console.Write("Exercise 13      ");
                    Console.Write("Exercise 14      ");
                    Console.WriteLine("Exercise 15       ");
                    Console.Write("Exercise 16      ".PadLeft(35));
                    Console.Write("Exercise 17      ");
                    Console.Write("Exercise 18      ");
                    Console.Write("Exercise 19      ");
                    Console.WriteLine("Exercise 20       ");
                    Console.WriteLine("\n\n");
                    Console.ResetColor();
                    Console.Write("Enter exercise number or -1 to exit: ".PadLeft(70));
                    
                    int assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ResetColor();
                    Console.WriteLine("\n\n");

                    switch (assignmentChoice)
                    {
                        case 1:
                            Class1.RunExerciseOne();
                            break;
                        case 2: 
                            Class1.RunExerciseTwo();
                                break;
                        case 3:
                            Class1.RunExerciseThree();
                                break;
                        case 4:
                            Class1.RunExerciseFour();
                                break;
                        case 5:
                            Class1.RunExerciseFive();
                                break;
                        case 6:
                            Class1.RunExerciseSix();
                            break;
                        case 7:
                            Class1.RunExerciseSeven();
                            break;
                        case 8:
                            Class1.RunExerciseEight();
                            break;
                        case 9:
                            Class1.RunExerciseNine();
                            break;
                        case 10:
                            Class1.RunExerciseTen();
                            break;
                        case 11:
                            Class1.RunExerciseEleven();
                            break;
                        case 12:
                            Class1.RunExerciseTwelve();
                            break;
                        case 13:
                            Class1.RunExerciseThirteen();
                            break;
                        case 14:
                            Class1.RunExerciseFourteen();
                            break;
                        case 15:
                            Class1.RunExerciseFifteen();
                            break;
                        case 16:
                            Class1.RunExerciseSixteen();
                            break;
                        case 17:
                            Class1.RunExerciseSeventeen();
                            break;
                        case 18:
                            Class1.RunExerciseEighteen();
                            break;
                        case 19:
                            Class1.RunExerciseNineteen();
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