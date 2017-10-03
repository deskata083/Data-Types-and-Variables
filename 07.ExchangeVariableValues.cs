namespace ExchangeVariableValues
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            int a = 5;
            int b = 10;
            Console.WriteLine($"Before:\r\na = {a}\r\nb = {b}");

            int c = b;
            b = a;
            a = c;

            Console.WriteLine($"After:\r\na = {a}\r\nb = {b}");
        }
    }
}
