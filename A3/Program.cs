using System;

namespace A3
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            var pi = Math.PI;
            Console.WriteLine($"1.{date:MMMM dd,yyyy}");
            Console.WriteLine($"2.{date:yyyy.M.d}");
            Console.WriteLine($"3.Day {date:dd} of {date:MMMM, yyyy}");
            Console.WriteLine($"4.Year:{date:yyyy}, Month:{date:MM}, Day:{date:dd}");
            Console.WriteLine($"5.      {date,10:dddd}");
            Console.WriteLine($"6.  {date,2:t}       {date,10:dddd}");
            Console.WriteLine($"7.h:{date:HH},m:{date:mm},s:{date:ss}");
            Console.WriteLine($"8.{date:yyyy}.{date:MM}.{date:dd}.{date:HH}.{date:mm}.{date:ss}");
            Console.WriteLine("---------------");
            Console.WriteLine($"1.{pi:C}");
            Console.WriteLine($"2.      {pi,10:n3}");
            
            
            
            
        }
    }
}
