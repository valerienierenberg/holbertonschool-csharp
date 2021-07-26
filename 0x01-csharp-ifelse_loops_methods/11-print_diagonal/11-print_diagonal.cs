using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            Console.WriteLine();
        }
        else
        {
            string spaces = "";
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(spaces + @"\");
                spaces += " ";
            }
            Console.WriteLine();
        }
    }
}
