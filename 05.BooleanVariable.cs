namespace BooleanVariable
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string s = Console.ReadLine();
            bool a = Convert.ToBoolean(s);

            if (a)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
