using System;
using System.Collections.Generic;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace Student_Services
{
    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }
        public int TestScore { get; set; }

        public bool LoggedIn { get; set; }
        public Student(string name, string email, string password,int testScore,bool loggedIn)
        {
            Name = name;
            Email = email;
            Password = password;
            TestScore = testScore;
            LoggedIn = loggedIn;
        }
        public static Student John = new Student("John Doe", "john@gmail.com", "john12",0,false);
        public static Student Jenny = new Student("Jenny Doe", "jenny@gmail.com", "jenny12",0,false);
        public static Student Bob = new Student("Bob Bobski", "bob@gmail.com", "bob12",0,false);





    public static Student ValidateStudent(string email, string password)
    {
            try {
                if (Student.John.Email == email && Student.John.Password == password)
                {
                    return John;

                }

                if (Student.Bob.Email == email && Student.Bob.Password == password)
                {
                    return Bob;
                }

                if (Student.Jenny.Email == email && Student.Jenny.Password == password)
                {
                    return Jenny;
                }

            }

            catch (Exception x)
            {
                Console.WriteLine($"{x.Message}");
            }

            return null;
        }


        public static void isHeLoggedIn()
        {
            if (Student.Bob.LoggedIn == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Student {Bob.Name} has logged In ");
                Console.WriteLine($"The Student has a Score of {Bob.TestScore}");
                Console.ResetColor();
            }
            if (Student.John.LoggedIn == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Student {John.Name} has logged In ");
                Console.WriteLine($"The Student has a Score of {John.TestScore}");
                Console.ResetColor();
            }
            if (Student.Jenny.LoggedIn == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"The Student {Jenny.Name} has logged In ");
                Console.WriteLine($"The Student has a Score of {Jenny.TestScore}");
                Console.ResetColor();
            }
               if (Student.Bob.LoggedIn == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The Student {Bob.Name} has not logged In ");
                Console.ResetColor();
            }
            if (Student.John.LoggedIn == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The Student {John.Name} has not logged In ");
                Console.ResetColor();
            }
            if (Student.Jenny.LoggedIn == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The Student {Jenny.Name} has not logged In ");
                Console.ResetColor();
            }
        }
}

}
