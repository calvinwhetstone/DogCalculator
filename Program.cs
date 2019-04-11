using System;

namespace dogs
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome to the dog age calculator! To start, tell us how old you are!");
            string myAge = Console.ReadLine().ToLower();
            int age;
            int dogYears = 7;
            bool rightAnswer = false;




            //Checks for Int. If not it repeats until it's an int
            if (!int.TryParse(myAge, out age))
            {
                Console.WriteLine("{0} is not an integer", myAge);
                rightAnswer = false;
                while (rightAnswer == false)
                {
                    Console.WriteLine("Please enter your age as an integer!");
                    myAge = Console.ReadLine().ToLower();
                    if (int.TryParse(myAge, out age))
                    {
                        rightAnswer = true;
                        continue;
                    }

                }
            }
            else
            {
                rightAnswer = true;
            }




            //Once answer is an int
            if (rightAnswer == true)
            {
                Console.WriteLine("Would you like to see your age in dog years? (yes/no)");
                var myOtherDogAge = (age + 1.5) * dogYears;
                var myDogAge = age * dogYears;
                var answer = Console.ReadLine().ToLower();


                while (answer != "yes" && answer != "no" && answer != "yes/no")
                {
                    Console.WriteLine($"{answer} is invalid. Would you like to see your age in dog years? (yes/no)");
                    answer = Console.ReadLine().ToLower();
                    if (answer == "yes" || answer == "no")
                    {
                        break;

                    }

                }

                //wants age in dog years

                if (answer == "yes")
                {
                    Console.WriteLine($"You are {myDogAge} in dog years!");
                    Console.WriteLine("Would you like to know how old in dog years you will be in 1.5 years? (yes/no)");
                    string dogAnswer = Console.ReadLine().ToLower();
                    ;

                    while (dogAnswer != "yes" && dogAnswer != "no" && dogAnswer != "yes/no")
                    {
                        Console.WriteLine($"{dogAnswer} is invalid. Would you like to know how old in dog years you will be in 1.5 years? (yes/no)");
                        dogAnswer = Console.ReadLine().ToLower();
                        if (dogAnswer == "yes" || dogAnswer == "no")
                        {
                            break;
                        }
                    }

                    // wants age in dog years and additional years
                    if (dogAnswer == "yes")
                    {

                        Console.WriteLine($"In 1.5 years you will be {myOtherDogAge}");
                        Console.WriteLine("Would you like a high 5? (yes/no)");
                        string highFive = Console.ReadLine().ToLower();

                        while (highFive != "yes" && highFive != "no" && highFive != "yes/no")
                        {
                            Console.WriteLine($"{highFive} is invalid. Would you like a high 5? (yes/no)");
                            highFive = Console.ReadLine().ToLower();
                            if (highFive == "yes" || highFive == "no")
                            {
                                break;
                            }
                        }

                        // yes to both and then high five question
                        if (highFive == "yes")
                        {
                            Console.WriteLine("*I give you a high 5*");
                        }
                        else if (highFive == "no")
                        {
                            Console.WriteLine("*I slap you in the face*");
                        }

                        else if (highFive == "yes/no")
                        {
                            Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                            System.Environment.Exit(1);

                        }

                    }
                    //yes to first and no to second now high five question
                    else if (dogAnswer == "no")
                    {

                        Console.WriteLine("Would you like a high 5? (yes/no)");
                        string highFive = Console.ReadLine().ToLower();
                        while (highFive != "yes" && highFive != "no" && highFive != "yes/no")
                        {
                            Console.WriteLine($"{highFive} is invalid. Would you like a high 5? (yes/no)");
                            highFive = Console.ReadLine().ToLower();
                            if (highFive == "yes" || highFive == "no")
                            {
                                break;
                            }
                        }
                        if (highFive == "yes")
                        {
                            Console.WriteLine("*I give you a high 5*");
                        }
                        else if (highFive == "no")
                        {
                            Console.WriteLine("*I slap you in the face*");
                        }

                        else if (highFive == "yes/no")
                        {
                            Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                            System.Environment.Exit(1);

                        }

                    }

                    else if (dogAnswer == "yes/no")
                    {
                        Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                        System.Environment.Exit(1);
                    }




                }
                //doesn't want age in dog years now ask about additional age
                else if (answer == "no")
                {

                    Console.WriteLine("Ok would you be interested in knowing how old you would be in dog years in 1.5 years? (yes/no)");
                    string dogAnswer = Console.ReadLine().ToLower();

                    while (dogAnswer != "yes" && dogAnswer != "no" && dogAnswer != "yes/no")
                    {
                        Console.WriteLine($"{dogAnswer} is invalid. would you be interested in knowing how old you would be in dog years in 1.5 years? (yes/no)");
                        dogAnswer = Console.ReadLine().ToLower();
                        if (dogAnswer == "yes" || dogAnswer == "no")
                        {
                            break;
                        }
                    }

                    if (dogAnswer == "yes")
                    {
                        Console.WriteLine($"In 1.5 years you will be {myOtherDogAge}");
                        Console.WriteLine("Would you like a high 5? (yes/no)");
                        string highFive = Console.ReadLine().ToLower();

                        while (highFive != "yes" && highFive != "no" && highFive != "yes/no")
                        {
                            Console.WriteLine($"{highFive} is invalid. Would you like a high 5? (yes/no)");
                            highFive = Console.ReadLine().ToLower();
                            if (highFive == "yes" || highFive == "no")
                            {
                                break;
                            }
                        }


                        if (highFive == "yes")
                        {
                            Console.WriteLine("*I give you a high 5*");
                        }
                        else if (highFive == "no")
                        {
                            Console.WriteLine("*I slap you in the face*");
                        }

                        else if (highFive == "yes/no")
                        {
                            Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                            System.Environment.Exit(1);

                        }

                    }



                    else if (dogAnswer == "no")
                    {
                        Console.WriteLine("Would you like a high 5? (yes/no)");
                        string highFive = Console.ReadLine().ToLower();

                        while (highFive != "yes" && highFive != "no" && highFive != "yes/no")
                        {
                            Console.WriteLine($"{highFive} is invalid. Would you like a high 5 (yes/no)");
                            highFive = Console.ReadLine().ToLower();
                            if (highFive == "yes" && highFive == "no")
                            {
                                break;
                            }
                        }


                        if (highFive == "yes")
                        {
                            Console.WriteLine("*I give you a high 5*");
                        }
                        else if (highFive == "no")
                        {
                            Console.WriteLine("*I slap you in the face*");
                        }

                        else if (highFive == "yes/no")
                        {
                            Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                            System.Environment.Exit(1);

                        }



                    }
                    else if (dogAnswer == "yes/no"){
                        Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                        System.Environment.Exit(1);
                    }
                }
                    else if (answer == "yes/no")
                    {
                        Console.WriteLine("You are an idiot and can not be trusted with this knowledge!");
                        System.Environment.Exit(1);
                    }
                }



                /*Console.WriteLine($"You are {age} old in human years!");
                           Console.WriteLine($"That makes you {myDogAge} in dog years!");

                Console.WriteLine($"If you are curious how old you will be in dog years in 1.5 years, you will be {myOtherDogAge}!"); */

            }
        }
    }