namespace IntegerToHexAndBinary
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            string result1 = Convert.ToString(num, 16).ToUpper();
            string result2 = Convert.ToString(num, 2).ToUpper();

            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
