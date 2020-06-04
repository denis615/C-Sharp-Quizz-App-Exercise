using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizzApp
{
  public class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public string Password { get; set; }

        public Teacher(string name,string email,string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

         public static Teacher Denis = new Teacher("Denis Sakipi", "denis615@gmail.com", "denis1312");

        public static bool ValidateTeacher(string email,string password)
        {
       
            if (email == Denis.Email && password == Denis.Password)
            {
               
                return true;
            }
            else
            {
         
              
                return false;
            }
            
        }
    }
}
