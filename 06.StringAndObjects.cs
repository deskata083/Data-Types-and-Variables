namespace StringAndObjects
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string first = "Hello";
            string second = "World";

            object obj = first + " " + second;
            obj = (string)obj;

            Console.WriteLine(obj);
        }
    }
}
