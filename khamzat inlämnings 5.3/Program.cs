using System;

namespace Uppgift_5._3_khamzat
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] tal = new int[3];
                Console.WriteLine("skriv 3 tal som programmet ska  plussas med varann");

                tal[0] = int.Parse(Console.ReadLine());
                tal[1] = int.Parse(Console.ReadLine());
                tal[2] = int.Parse(Console.ReadLine());


                Console.WriteLine("summan av dina tal " + (tal[0] + tal[1] + tal[2]));

                
            }
            catch
            {
                Console.WriteLine("du skrev inte heltal");
                Console.ReadKey();
            }

        }

    }
}