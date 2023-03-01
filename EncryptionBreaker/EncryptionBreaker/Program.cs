using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {


        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }

        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }


        static void Main(string[] args)
        {

            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to EncryptionBreaker game, here yoyu will be asked to enter a string, which will then be encrypted, you are expected to huess the encryption key for cesar cipher");
            Console.ResetColor();
            Console.WriteLine("Type a string to encrypt:");
            string UserString = Console.ReadLine();

            Console.WriteLine("\n");
            System.Random random = new System.Random();
            int key = random.Next(1, 26);
            Console.WriteLine("\n");


            Console.WriteLine("Encrypted Data");

            string cipherText = Encipher(UserString, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Guess the Encryption Key");

            int guess = 0; 
            while( guess!= key)
            {
                string userGuess= Console.ReadLine();
                guess= Int32.Parse(userGuess);

                if( guess != key )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Incorrect, please try again. ");
                    Console.ResetColor();
                }
            }

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("You are correct! ");




            Console.ReadKey();

        }
    }
}