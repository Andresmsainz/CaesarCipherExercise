using System;

namespace CaesarCipherExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caesar Cipher Exercise!");
            string plainText = "Zorro";
            string cipherText = "cruur";
            char[] cipher;

            Console.WriteLine("Plain text:");

            foreach (var item in plainText)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            Console.WriteLine("Cipher Text : ");

            cipher = CaesarCipher.Encrypt(plainText, 3);
            foreach (var item in cipher)
            {
                Console.Write(item);
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Decrypted Text : ");
            foreach (var item in CaesarCipher.Decrypt(cipherText,3))
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }

    class CaesarCipher
    {
        public static char[] Encrypt(string plainText, int shift)
        {
            char[] plainArray = plainText.ToLower().ToCharArray();
            char[] cipherArray = new char[plainArray.Length];

            for (int i = 0; i < plainArray.Length; i++)
            {
                char letter = plainArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter + shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return cipherArray;
        }

        public static char[] Decrypt(string cipherText, int shift)
        {
            char[] ciphherArray = cipherText.ToLower().ToCharArray();
            char[] plainArray = new char[cipherText.Length];

            for (int i = 0; i < ciphherArray.Length; i++)
            {
                char letter = ciphherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    plainArray[i] = letter;
                }
            }
            return plainArray;
        }
    }
}
