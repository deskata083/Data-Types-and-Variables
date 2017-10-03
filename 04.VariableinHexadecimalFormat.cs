namespace VariableinHexadecimalFormat
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            int num = Convert.ToInt32(s, 16);
            Console.WriteLine(num);
        }
    }
}
