using System;

namespace _3_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char alph = 'a'; alph <= 'z'; alph++)
            {
                if (alph != 'e' && alph != 'q')
                {
                    Console.Write(alph);
                }
            }
        }
    }
}
