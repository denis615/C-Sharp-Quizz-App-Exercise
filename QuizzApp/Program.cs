using System;
using  Student_Services;
using Quizz_Services;
using System.Diagnostics.CodeAnalysis;

namespace QuizzApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int wrongStudent = 0;
            int wrongTeacher = 0;
            while (true)
            {
                Console.Clear();
            Console.WriteLine("Welcome to the Quizz App, Press 1 if you are loggin in as a Student, or Press 2 to log in as a Teacher");
            string firstChoise = Console.ReadLine();

            
           
                if (firstChoise == "1")
                {
                    while (true) {
                        Console.Clear();
                       
                        Console.WriteLine("Please write the student email?");
                    string email = Console.ReadLine();
                    Console.WriteLine("Plese write the student password?");
                    string password = Console.ReadLine();
                       var loggedStudent = Student.ValidateStudent(email, password);
                  try { 
                        if (Student.Bob.LoggedIn == true&&loggedStudent.Name==Student.Bob.Name)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Student.Bob.Name} has already taken the Test");
                            Console.ResetColor();
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            continue;
                        }
                        if (Student.Jenny.LoggedIn == true &&loggedStudent.Name == Student.Jenny.Name)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Student.Jenny.Name} has already taken the Test");
                            Console.ResetColor();
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            continue;
                        }
                        if (Student.John.LoggedIn == true && loggedStudent.Name == Student.John.Name)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"{Student.John.Name} has already taken the Test");
                            Console.ResetColor();
                            Console.WriteLine("Press Enter To Continue");
                            Console.ReadLine();
                            continue;
                        }
                        }

                        //If I logg in for the first time, take the test, and then If I have a wrong Username or Password with another User, I have a null Error. PLease tell me how to fix it.
                        catch(NullReferenceException x)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong email/Password please try Again");
                            Console.ResetColor();
                            Console.WriteLine("Press Enter to Try Again");
                            Console.ReadLine();
                            wrongStudent++;
                            if (wrongStudent == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Too Manny Wrong Entries Goodbye");
                                Environment.Exit(0);
                            }

                        }
                        if (loggedStudent != null)
                        {
                            Console.WriteLine($"Welcome {loggedStudent.Name}");
                            Questions.AddQuestions();
                            int Score = Questions.AnswerQuestions();

                            if (loggedStudent.Name == Student.Bob.Name)
                            {
                              Student.Bob.TestScore=Score;
                                Student.Bob.LoggedIn = true;

                            }

                            if (loggedStudent.Name == Student.Jenny.Name)
                            {
                               Student.Jenny.TestScore=Score;
                                Student.Jenny.LoggedIn = true;
                            }

                            if (loggedStudent.Name == Student.John.Name)
                            {
                              Student.John.TestScore=Score;
                                Student.John.LoggedIn = true;
                            }
                            break;
                    }

                      if(loggedStudent==null)
                        {
                            
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong email/Password please try Again");
                            Console.ResetColor();
                            Console.WriteLine("Press Enter to Try Again");
                            Console.ReadLine();
                            wrongStudent++;
                            if (wrongStudent == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Too Manny Wrong Entries Goodbye");
                                Environment.Exit(0);
                            }
                            continue;
                        }
                    }
                }
                if (firstChoise == "2")
                {
                    while (true) { 
                    Console.Clear();
                    Console.WriteLine("Please write the Teacher Email?");
                    string email = Console.ReadLine();
                    Console.WriteLine("Please write the Teacher Password?");
                    string password = Console.ReadLine();

                    if (Teacher.ValidateTeacher(email, password) == true)
                    {
                          
                            Student.isHeLoggedIn();
                         
                            Console.ReadLine();
                            break;
                    }
                    if (Teacher.ValidateTeacher(email, password) == false)
                    {
                            wrongTeacher++;
                            if (wrongTeacher == 3)
                            {
                                Console.WriteLine("Too Many Wrong Tries Goodbye");
                                Environment.Exit(0);
                            }

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong UserName Or Password Press Enter to try Again");
                            Console.ResetColor();
                            Console.ReadLine();
                            continue;
                    }

                    }

                }

                else if(firstChoise!="1"&&firstChoise!="2")
                {
                    Console.WriteLine("PLease Enter either 1 or 2");
                    Console.WriteLine("Press Anykey to continue");
                    Console.ReadLine();
                    continue;
                }
                continue;
            }
        }
    }
}