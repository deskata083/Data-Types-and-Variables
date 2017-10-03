namespace vowelOrDigit
{
    using System;
    public class startUp
    {
        public static void Main()
        {
            string vhod = Console.ReadLine();
            int num = 0;

            try
            {
                num = Convert.ToInt32(vhod);
                Console.WriteLine("digit");
            }
            catch(Exception)
            {
                if((vhod =="a")||(vhod == "e")||(vhod== "i")||(vhod=="o")||(vhod=="u"))
                {
                    Console.WriteLine("vowel");
                }
                else
                {
                    Console.WriteLine("other");
                }
            }
        }
    }
}
