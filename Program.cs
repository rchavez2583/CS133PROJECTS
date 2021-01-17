using System;

namespace CS133PROJECTS
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[,] arr2d = new int[1, 10]

            {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 },
             




            };

            for (int Y = 1; Y < 11; Y++)
            {
                for (int X = 1; X < 11; X++)
                {
                    Console.Write((X,Y) + " ");
                }

                Console.WriteLine("");
            }





        }

    }
}
