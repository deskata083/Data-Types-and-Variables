namespace RectangleProperties
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());

            double perimeter = 2 * width + 2 * lenght;
            double area = width * lenght;
            double diag = Math.Sqrt(width * width + lenght * lenght);

            Console.WriteLine("{0}\r\n{1}\r\n{2}", perimeter, area, diag);
        }
    }
}
