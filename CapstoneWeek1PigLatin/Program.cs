using System;

namespace CapstoneWeek1PigLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            bool UserContinue = true;
            while(UserContinue == true)
            { 
            Console.WriteLine("Please enter a word");

                string UserInput = Console.ReadLine();

                char [] vowels = { 'a', 'e', 'i', 'o', 'u'};

                
                int index = UserInput.ToLower().IndexOfAny(vowels);
                
                if (index==0)
                {
                    Console.WriteLine(UserInput + "way");
                }
                else if (index > 0)
                {
                    Console.WriteLine(UserInput.Substring(index) + 
                        UserInput.Substring(0,index) + "ay");
                }
                else
                {
                    Console.WriteLine("Pig latin only works when the word has a vowel.");
                }
                    Console.WriteLine("Would you like to translate another word? y/n");
                    string choice = Console.ReadLine();
                if (choice.ToLower() == "no" || choice.ToLower() == "n")
                { 
                    UserContinue = false;
                }


            }
            }
    }
}
