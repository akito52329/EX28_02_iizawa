using System;

namespace EX28
{
    class Constructor
    {
        public static int Input(string messege)
        {
            Console.WriteLine(messege);
            return int.Parse(Console.ReadLine()); 
        }
    }
}
