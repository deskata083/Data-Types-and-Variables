namespace TheaThePhotographer
{
    using System;
    public class StartUp
    {
        public static void Main()
        {
            ulong numberOfPic = ulong.Parse(Console.ReadLine());
            ulong filterTime = ulong.Parse(Console.ReadLine());
            ulong percent = ulong.Parse(Console.ReadLine());
            ulong uploadTime = ulong.Parse(Console.ReadLine());

            ulong filteredPic =(ulong) Math.Ceiling(numberOfPic * percent / 100.0);
            //int totalFTime = numberOfPic * filterTime;
            //int totalUploadTime = filteredPic * uploadTime;
            //int totalTime = totalFTime + totalUploadTime;

            ulong totalTime = (numberOfPic * filterTime) + (filteredPic * uploadTime);

            ulong days = totalTime / 86400;
            ulong sec = totalTime % 86400;
            ulong hours = sec / 3600;
            sec = sec % 3600;
            ulong min = sec / 60;
            sec = sec % 60;
           // double sec = hours % 3600;
            
            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", 
                 days ,hours, min, sec);

        }
    }
}
