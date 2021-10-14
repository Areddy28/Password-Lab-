using System;
using System.Collections.Generic;

namespace PasswordRegLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> userNames = new List<string>();
            List<string> passWords = new List<string>();

            bool Continue = true; 

            while(Continue == true)


            {
                Console.WriteLine("Welcome to the Password Registration Generator!");


                Console.WriteLine("Please enter a username");
                string username = Console.ReadLine();


                bool validUsername = VerifyUser(username); 

                if (validUsername == true)
                {
                    Console.WriteLine("Please enter a password");
                    string password = Console.ReadLine();

                    bool validPassword = VerifyPass(password); 

                    if (validUsername == true && validPassword == true)
                    {
                        userNames.Add(username);
                        passWords.Add(password);
                        Console.WriteLine("The new user has been added");
                    }

                    for (int i = 0; i < userNames.Count; i++)
                    {
                        Console.WriteLine(userNames[i] + "\t" + "\t" + "\t" + passWords);
                    }
                }
                else
                {
                    Console.WriteLine("Username is incorrect please follow the rules");
                }
                Continue = CarryOn(); 
            }

        }

        public static bool CarryOn()
        {
            Console.WriteLine("Would you like to conrinue and add another user? y/n");

            string message = Console.ReadLine().ToLower(); 

            if (message.ToLower() == "y")
            {
                return true; 
            }
            else if (message.ToLower() == "n")
            {
                Console.WriteLine("Bye have a nice life!");
                return false; 
            }
            else
            {
                Console.WriteLine("Not valid!");
                Console.WriteLine("Try again!");

                return CarryOn(); 
            }
        }

        public static bool VerifyUser (string user)
        {
            if (user.Length >= 7 && user.Length <= 12)
            {
                return true; 
            }
            else
            {
                Console.WriteLine("Username must be a length of 7 character minimum and no longer than 12 characters maximum!");
                return false; 
            }
        }

        public static bool VerifyPass (string pass)
        {
            if (pass.Length >= 7 && pass.Length <= 12)
            {

                //Console.WriteLine("Password must be at least a minimum of 7 characters and maximum of 12 characters");
                return true; 
            } 
            else if (pass.Length < 7 || pass.Length > 12)
            {
                Console.WriteLine("Password must be at least a minimum of 7 characters and maximum of 12 characters");
            }

            else if (pass.ToLower() == pass || pass.ToUpper() == pass)
            {
                return true;

            } 
             else if (pass.Contains("$") && pass.Contains("%"))
            {
                return true; 
            }

            return true; 

            
        }
    }
}
