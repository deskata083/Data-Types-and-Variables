﻿namespace ReverseCharacters
{
    using System;
    public class Program
    {
        public static void Main()
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            Console.WriteLine($"{c}{b}{a}");
        }
    }
}
