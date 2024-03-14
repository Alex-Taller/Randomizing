using System;
using System.Threading;
// See https://aka.ms/new-console-template for more information

public class RandomNumbers
{
    public static void Main(string[] args)
    {
        Random numbers = new Random();
        int numbOfCubes = 0;
        int RandomizElements;
        int firCorner, secCorner;
        string? answer1;
        Console.WriteLine("Take a number of an elements:");
        int[] randNumber = new int[numbOfCubes = Convert.ToInt32(Console.ReadLine())];
        if (Console.ReadLine() is null || numbOfCubes == 0)
        {
            throw new Exception("Number of elements need to be much more then 0");
        }
        Console.WriteLine("Give a borders of diapasone| 1 bordrer. Enter => 2 border");
        firCorner = Convert.ToInt32(Console.ReadLine());
        secCorner = Convert.ToInt32(Console.ReadLine());
        if (Console.ReadLine() is null || secCorner == 0)
        {
            throw new Exception("Number of elements need to be much more then 0");
        }
        for (int i = 0; i < randNumber.Length; i++)
        {
            RandomizElements = numbers.Next(firCorner, secCorner);
            randNumber[i] = RandomizElements;
            Console.Write("{0, 5:N0}", RandomizElements);

        }

        Console.WriteLine();
        Console.WriteLine("Do you want to found numbers by their size?/ Write Y or N");
        answer1 = Convert.ToString(Console.ReadLine());
        if (Console.ReadLine() is null)
        {
            throw new Exception("Write Y/y or N/n");
        }
        if (answer1 == "Y" || answer1 == "y")
        {
            Console.WriteLine("Take diapasone of element:");
            int? Diaposone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Take a symbol of diapasone: >, <, >=,<= ");
            string? v = Convert.ToString(Console.ReadLine());
            if (Diaposone == null || v == null)
            {
                throw new Exception("Write the needed diaposone and symbols");
            }
            if (v == "<=" || v == "<")
            {
                for (int i = 0; i < randNumber.Length; i++)
                {

                    if (randNumber[i] <= Diaposone)
                    {
                        Console.Write("{0, 5:N0}", randNumber[i]);
                    }

                }
            }
            if (v == ">=" || v == ">")
            {
                for (int i = 0; i < randNumber.Length; i++)
                {
                    if (randNumber[i] >= Diaposone)
                    {
                        Console.Write("{0, 5:N0}", randNumber[i]);

                    }
                }
            }
        }
        else if (answer1 == "N" || answer1 == "n")
        {
            Console.WriteLine("Okey tap enter twice to close the programm");
        }
        else
        {
            Console.WriteLine("Shizoid I was needed Y or N");
        }
        Console.WriteLine();
        Console.WriteLine($"Number of cubes:{numbOfCubes}");
        Console.ReadKey();
    }
}