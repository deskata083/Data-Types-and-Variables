namespace ComparingFloats
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double eps = 0.000001;

            double diff = Math.Abs(a - b);
            bool compare;
            if (diff < eps)
            {
                compare = true;
            }
            else
            {
                compare = false;
            }
            Console.WriteLine(compare);
        }
    }
}
