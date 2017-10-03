namespace ConvertSpeedUnits
{
    using System;
    class StartUp
    {
        static void Main()
        {
            int metters = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int vhSeconds = int.Parse(Console.ReadLine());

            float seconds = hours * 3600 + minutes * 60 + vhSeconds;
            float firstSpeed = metters / seconds;
            float secondSpeed = (float)(firstSpeed * 3.6);
            float thirdSpeed = (float)(secondSpeed / 1.609);
            Console.WriteLine("{0}", firstSpeed);
            Console.WriteLine("{0}", secondSpeed);
            Console.WriteLine("{0}", thirdSpeed);


        }
    }
}
