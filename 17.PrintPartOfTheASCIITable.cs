namespace PrintPartOfTheASCIITable
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int firstIndex = int.Parse(Console.ReadLine());
            int secIndex = int.Parse(Console.ReadLine());

            for(int i = firstIndex; i<= secIndex; i++)
            {
                char ch = Convert.ToChar(i);
                Console.Write($"{ch} ");

            }

        }
    }
}
