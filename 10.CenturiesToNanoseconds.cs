namespace CenturiesToNanoseconds
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            uint centuries = uint.Parse(Console.ReadLine());
            
            uint years = centuries * 100;
            uint days = (uint)(years * 365.2422);
            uint hours = days * 24;
            uint minutes = hours * 60;
            decimal seconds = (decimal)minutes * 60;
            decimal milisec = 1000 * seconds;
            decimal microsec = 1000 * milisec;
            decimal nanosec = (1000 * microsec);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} " +
                $"hours = {minutes} minutes = {seconds} seconds = {milisec} milliseconds = {microsec} " +
                $"microseconds = {nanosec} nanoseconds");
        }
    }
}
