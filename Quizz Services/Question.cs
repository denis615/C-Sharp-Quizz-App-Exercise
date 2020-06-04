using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace Quizz_Services
{
    public class Questions
    {
        string Question { get; set; }
        string AnswerA { get; set; }
        string AnswerB { get; set; }
        string AnswerC { get; set; }
        string AnswerD { get; set; }

        public static List<Questions> questionsDataBase = new List<Questions>();
        public Questions(string question, string answerA, string answerB, string answerC, string answerD)
        {
            Question = question;
            AnswerA = answerA;
            AnswerB = answerB;
            AnswerC = answerC;
            AnswerD = answerD;


        }

        public static void AddQuestions()
        {
            Questions Tasmania = new Questions("What is The Capital of Tasamania?", "A)Dodoma", "B)Hobart", "C)Launceston", "D)Wellington");
            Questions Congo = new Questions("What is the Tallest building in the Republic of Congo?", "A)Kinsasha Temple", "B)Palais de la nation", "C)Kondo Trade Centre", "D)Nabemba Tower");
            Questions Pluto = new Questions("Which of these is not a Pluto Moon?", "A)Styx", "B)Hydra", "C)Nix", "D)Lugia");
            Questions Lake = new Questions("What is the smallest lake in the World?", "A)Onega Lake", "B)Benxi Lake", "C)Kivu Lake", "D)Wakatipu Lake");
            Questions Alpacas = new Questions("What country has the largest population of the ALpacas?", "A)Chad", "B)Peru", "C)Australia", "D)Niger");

            questionsDataBase.Add(Tasmania);
            questionsDataBase.Add(Congo);
            questionsDataBase.Add(Pluto);
            questionsDataBase.Add(Lake);
            questionsDataBase.Add(Alpacas);
        }



        public static int AnswerQuestions()
        {
            int score = 0;
            int i;
            for (i = 0; i <= questionsDataBase.Count()-1; i++)
            {
                try { 
               string[] correctAnswers = { "b", "d","d","a","b" };

               
                var firstQuestion = questionsDataBase.ElementAt(i);
                Console.WriteLine(firstQuestion.Question);
                Console.WriteLine(firstQuestion.AnswerA);
                Console.WriteLine(firstQuestion.AnswerB);
                Console.WriteLine(firstQuestion.AnswerC);
                Console.WriteLine(firstQuestion.AnswerD);
                string answer = Console.ReadLine();
                if (correctAnswers[i] == answer.ToLower())
                {
                    score++;
                }

                }
                catch(IndexOutOfRangeException x)
                {
                    break;
                }

            }
            
            Console.WriteLine($"You Have taken the test and your score is {score}");
            Console.WriteLine("Press Enter To Continue");
            Console.ReadLine();
            return score;
        }

    }
}