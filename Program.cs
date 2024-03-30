using System;

namespace numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            while (i <= 100)
            {
                if (i % 3 == 0)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine("Hello Goodbye");
                        i++;
                    }

                    else
                    {
                        Console.WriteLine("Hello");
                        i++;
                    }
                    
                }

                else if (i % 5 == 0)
                {
                    Console.WriteLine("Goodbye");
                    i++;
                }

                else
                {
                    Console.WriteLine(i);
                    i++;
                }
            }
        }
    }
}
