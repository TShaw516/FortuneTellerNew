using System;

namespace FortuneTellerNew
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable List
            string firstName = "";
            string lastName = "";
            string userAge = "";
            int birthMonth = 0;
            string favoriteRainbowColor = "";
            string amountOfSiblings = "";

            //Call Order
            
            CallFirstName(ref firstName);
            //Console.WriteLine("Your first name is {0}", fName);
            
            CallLastName(ref lastName);
            //Console.WriteLine("Your last name is {0}", lName);
            
            CallUserAge(ref userAge);
            //Console.WriteLine("You are {0} years old", uAge);
            
            birthMonth = CallUserMonth();
            Console.WriteLine("Your birth month is {0} ", birthMonth);
            
            CallRainbowColor(ref favoriteRainbowColor);
            //Console.WriteLine("Your favorite color of the rainbow is {0} ", roygbiv);
            
            CallSiblings(ref amountOfSiblings);
            //Console.WriteLine("you have {0} sibling(s)", uSiblings);
        }
        
        //First Name Method
        static void CallFirstName(ref string firstName)
        {
            Console.Write("Please enter first name: ");
            firstName = Console.ReadLine();
        }

        //Last Name Method
        static void CallLastName(ref string lastName)
        {
            Console.Write("Please enter last name: ");
            lastName = Console.ReadLine();
        }

        //User Age Method
        static void CallUserAge(ref string userAge)
        {
            Console.Write("Please enter your age: ");
            userAge = Console.ReadLine();
        }

        //User Month Method
        static int CallUserMonth()
        {
            Console.Write("Please enter the numerical value of your birth month: ");
            string monthString = Console.ReadLine();
            int userMonth = Convert.ToInt32(monthString);
            return userMonth;
        }

        //ROYGBIV Method
        static void CallRainbowColor(ref string rainbowColor)
        {
            //Ask the user if they know ROYGBIV
            Console.Write("Do you know what ROYGBIV means? (yes/no): ");
            string help = Console.ReadLine();

            //Check the condition if yes/no
            if (help == "no")
            {
                Console.WriteLine("ROYGVIC is the colors of the rainbow");
                Console.WriteLine("Please enter your favorite ROYGBIV color: ");
                rainbowColor = Console.ReadLine();

            }
            else
            {
                Console.WriteLine("Please enter your favorite ROYGBIV color: ");
                rainbowColor = Console.ReadLine();
            }
        }

        //Siblings Amount Method
        static void CallSiblings(ref string siblingsAmount)
        {
            Console.Write("How many siblings do you have?: ");
            siblingsAmount = Console.ReadLine();      
        }
    }
    }

