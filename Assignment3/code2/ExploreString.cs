using System;

namespace ExploreString
{

    class ExString
    {

        public static void findLength()
        {
            Console.WriteLine("FINDING THE LENGTH OF A STRING: ");
            string s;
            Console.WriteLine($"Enter a String : ");
            s = Console.ReadLine();

            Console.WriteLine($"The length of the String is : {s.Length}");
        }

        public static void checkType()
        {

            Console.WriteLine("Checking The Type of The String: ");
            string s;
            Console.WriteLine($"Enter a String : ");
            s = Console.ReadLine();

            int len = s.Length;

            if ((char)s[len - 1] == '.')
            {
                Console.WriteLine($"String \"{s}\" is Declarative Sentence");
            }
            else if ((char)s[len - 1] == '!')
            {
                Console.WriteLine($"String \"{s}\" is Exclamation Sentence");
            }
            else if ((char)s[len - 1] == '?')
            {
                Console.WriteLine($"String \"{s}\" is Interrogatory Sentence");
            }
            else
            {
                Console.WriteLine($"String \"{s}\" is not a  Sentence");
            }

        }

        public static void printName()
        {
            Console.WriteLine("Checking The Type of The String: ");
            string s;
            Console.WriteLine("Enter your Name : ");
            s = Console.ReadLine();

            int index = s.IndexOf(" ");


            if (index != -1)
            {
                // Console.WriteLine($"{index}");
                int len = s.Length;
                // Console.WriteLine($"{len}");

                string firstName = s.Substring(0, index);
                string lastName = s.Substring(index + 1, len - index - 1);
                Console.WriteLine($"{lastName} , {firstName}");
            }
            else
                Console.WriteLine($"{s}");



        }
    }
}