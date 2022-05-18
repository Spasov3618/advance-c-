using System;
using System.Collections.Generic;
namespace _8._Traffic_Jam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            string cmd;
            int counter = 0;
            while ((cmd = Console.ReadLine()) != "end")
            {
                if (cmd != "green")
                {
                    queue.Enqueue(cmd);
                }
                else if (cmd == "green")
                {
                    

                    for (int i = 0; i < number; i++)
                    {
                    if (queue.Count>0)
                        { 
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
