using System;

namespace Learning
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to the dog age calculator! To start, tell us how old you are!");
            string myAge = Console.ReadLine();
            int age;
            int dogYears = 7;



            /* var dogAnswer = Console.ReadLine();
             var highFive = Console.ReadLine(); */



            if (!int.TryParse(myAge, out age))
            {
                Console.WriteLine("{0} is not an integer", myAge);
                // 
            }
            else
            {
                Console.WriteLine("Would you like to see your age in dog years? (yes/no)");
                var myOtherDogAge = (age + 1.5) * dogYears;
                var myDogAge = age * dogYears;
                var answer = Console.ReadLine();

          
              
                if (answer == "yes")
                {
                    Console.WriteLine($"You are {myDogAge} in dog years!");
                    Console.WriteLine("Would you like to know how old in dog years you will be in 1.5 years? (yes/no)");
                    string dogAnswer = Console.ReadLine();
                    ;
                        if (dogAnswer == "yes")
                            {
                     
                        Console.WriteLine($"In 1.5 years you will be {myOtherDogAge}");
                                Console.WriteLine("Would you like a high 5? (yes/no)");
                        string highFive = Console.ReadLine();
                        if (highFive == "yes")
                                {
                                    Console.WriteLine("*I give you a high 5*");
                                }
                                else
                                {
                                    Console.WriteLine("*I slap you in the face*");
                                }
                            }
                }

                else
                {
                  
                    Console.WriteLine("Ok would you be interested in knowing how old you would be in dog years in 1.5 years? (yes/no)");
                    string dogAnswer = Console.ReadLine();
                    if (dogAnswer == "yes")
                                    {
                        Console.WriteLine($"In 1.5 years you will be {myOtherDogAge}");
                                        Console.WriteLine("Would you like a high 5? (yes/no)");
                         string highFive = Console.ReadLine();
                        if (highFive == "yes")
                                        {
                                            Console.WriteLine("*I give you a high 5*");
                                        }
                                        else
                                        {
                                            Console.WriteLine("*I slap you in the face*");
                                        }
                                    }
                    else
                                {
                                    Console.WriteLine("Would you like a high 5? (yes/no)");
                        string highFive = Console.ReadLine();
                        if (highFive == "yes")
                                    {
                                        Console.WriteLine("*I give you a high 5*");
                                    }
                                    else
                                    {
                                        Console.WriteLine("*I slap you in the face*");
                                    }
                                }

                }
            }

         
       
 /*Console.WriteLine($"You are {age} old in human years!");
            Console.WriteLine($"That makes you {myDogAge} in dog years!");
            Console.WriteLine($"If you are curious how old you will be in dog years in 1.5 years, you will be {myOtherDogAge}!"); */

        }
    }
}
