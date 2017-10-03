namespace FastPrimeChecker
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            bool prime;

            for (int i = 2; i <= a; i++)
            {
                prime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        prime = false;
                    }
                }
                Console.WriteLine($"{i} -> {prime}");
            }
        }

    }
}

