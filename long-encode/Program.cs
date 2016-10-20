using System;

namespace long_encode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Lets().Encode(long.MaxValue));
        }
    }
}
