namespace EmployeeData
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            string lastname = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long id = long.Parse(Console.ReadLine());
            int unique = int.Parse(Console.ReadLine());

            Console.WriteLine($"First name: {name}");
            Console.WriteLine($"Last name: {lastname}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Personal ID: {id}");
            Console.WriteLine($"Unique Employee number: {unique}");


        }
    }
}
