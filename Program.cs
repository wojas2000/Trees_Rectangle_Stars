using System;

namespace Trees_Rectangle_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rectangle
            var n = int.Parse(Console.ReadLine());            
            Console.WriteLine(new String('*', n));           
            for(int i = 1; i < n - 1; i++)
            {
                Console.Write("*");
                Console.Write(new String(' ', n - 2));
                Console.WriteLine("*");
            }
            Console.WriteLine(new String('*', n));

            //Half Tree
            var z = int.Parse(Console.ReadLine()); //Tree high
            for(int i = 1; i <= z; i++)
            {
                for(int j = 1; j <= z; j++)
                {
                    Console.Write(new String(' ', z - j));
                    Console.WriteLine(new String('*', j));
                }
            }
        } 
    }
}
