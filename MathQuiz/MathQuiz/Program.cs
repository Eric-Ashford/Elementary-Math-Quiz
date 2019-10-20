using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathQuizECEric
{
    class Program
    {
        //MiniQuiz Extra Credit
        //Made By Eric Ashford

        static void Main()
        {
            Program myProgram = new Program();
            myProgram.Run();
        }


        public void Run()
        {
            
            int difficulty = 0;
            bool appRunning = true;
            

            while (appRunning)
            {
                Console.WriteLine("=====================================".PadLeft(60));
                Console.WriteLine("=====================================".PadLeft(60));
                Console.WriteLine("=============Mini Math Quiz==========".PadLeft(60));
                Console.WriteLine("=====================================".PadLeft(60));
                Console.WriteLine("=====================================".PadLeft(60));
                Console.WriteLine("Type 1 for Easy or 2 for Hard mode?".PadLeft(59));
                difficulty = Int32.Parse(Console.ReadLine());
                switch (difficulty)
                {
                    case 1:
                        Easy();
                        break;

                    case 2:
                        Hard();
                        break;

                    default:
                        appRunning = false;
                        break;

                }
            }
        }
            private void Easy()
            {
            int correct = 0;
            int answer;
            int a = 2;
            int b = 4;
            int c = 6;
            int d = 3;

          

            Console.Clear();
                Console.WriteLine("You have selected Easy mode. Get ready! ");

             Console.WriteLine("What is "+a+ " + " +b+"?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a+b)
                {Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

             Console.WriteLine("What is " + c + " + " + d + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == c + d)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

             Console.WriteLine("What is " + c + " + " + b + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == c + b)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

             Console.WriteLine("What is " + a + " + " + c + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a + c)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

             Console.WriteLine("What is " + d + " + " + b + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == d + b)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

             Console.WriteLine("What is " + a + " + " + d + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a + d)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                if (correct < 5)
                {
                    Console.WriteLine("Not Passing\n");
                }
                else
                {
                    Console.WriteLine("Pass!\n");
                }

            Console.WriteLine("The quiz is over, are you happy with your results?\n");

        }
            
            private void Hard()
            {
            int correct = 0;
            int answer;
            int a = 2;
            int b = 4;
            int c = 6;
            int d = 3;

            Console.Clear();
                Console.WriteLine("You have selected Hard mode. Get ready! \n");

                Console.WriteLine("What is " + a + " x " + b + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a * b)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                Console.WriteLine("What is " + c + " x " + d + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == c * d)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                Console.WriteLine("What is " + c + " x " + b + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == c * b)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                Console.WriteLine("What is " + a + " x " + c + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a * c)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                Console.WriteLine("What is " + d + " x " + b + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == d * b)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                Console.WriteLine("What is " + a + " x " + d + "?");
                answer = Convert.ToInt32(Console.ReadLine());
                if (answer == a * d)
                { Console.WriteLine("Correct"); correct++; }
                else { Console.WriteLine("Incorrect"); }

                if (correct < 5)
                {
                    Console.WriteLine("Not Passing\n");
                }
                else
                {
                    Console.WriteLine("Pass!\n");
                }

            Console.WriteLine("The quiz is over, are you happy with your results?\n");
        }

        }
    }
