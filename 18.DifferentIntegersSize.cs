namespace DifferentIntegersSize
{
    using System;
    public class StartUp
    {
        public static void Main()
        {

            int i = 0;
            string s = Console.ReadLine();
            try
            {
                long num = Convert.ToInt64(s);
                Console.WriteLine($"{num} can fit in:");
                try  
                {
                    sbyte fl = Convert.ToSByte(num);
                    Console.WriteLine("* sbyte"); //i++;
                }
                catch (Exception) { }
                try  
                {
                    byte fl = Convert.ToByte(num);
                    Console.WriteLine("* byte"); //i++;
                }
                catch (Exception) { }
                try  
                {
                    short fl = Convert.ToInt16(num);
                    Console.WriteLine("* short"); //i++;
                }
                catch (Exception) { }
                try  //  sbyte < byte < short < ushort < int < uint < long)
                {
                    ushort fl = Convert.ToUInt16(num);
                    Console.WriteLine("* ushort"); //i++;
                }
                catch (Exception) { }
                try  
                {
                    int fl = Convert.ToInt32(num);
                    Console.WriteLine("* int"); //i++;
                }
                catch (Exception) { }
                try  
                {
                    uint fl = Convert.ToUInt32(num);
                    Console.WriteLine("* uint"); //i++;
                }
                catch (Exception) { }
                try  
                {
                    long fl = Convert.ToInt64(num);
                    Console.WriteLine("* long"); //i++;
                }
                catch (Exception) { }
            }
            catch (Exception)
            {
                 Console.WriteLine($"{s} can't fit in any type");

            }

        }
    }
}



