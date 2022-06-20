using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._The_Fight_for_Gondor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numWaves = int.Parse(Console.ReadLine());
          
            Queue<int> plate = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> stack = new Stack<int>();
            ;
            for (int i = 1; i <= numWaves; i++)
            {
                stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

                if (i % 3 == 0)
                    {
                        int newPlate = int.Parse(Console.ReadLine());
                        plate.Enqueue(newPlate);

                    }
                while (plate.Count > 0 && stack.Count > 0)
                {
                    int platePower = plate.Peek();
                    int stackPower = stack.Peek();
                    if (platePower > stackPower)
                    {
                        plate.Dequeue();
                        Queue<int> plate1 =new Queue<int>(plate.Reverse());
                        plate1.Enqueue(platePower - stackPower);
                        plate =new Queue<int>(plate1.Reverse());
                        
                        stack.Pop();

                    }
                    else if (platePower < stackPower)
                    {
                        plate.Dequeue();
                        stack.Push(stack.Pop() - platePower);
                    }
                    else if (platePower == stackPower)
                    {
                        plate.Dequeue();
                        stack.Pop();
                    }

                }
                if (plate.Count==0 )
                {
                    break;
                }

                

            }
           
                if (plate.Count==0)
                {
                    Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                    Console.Write($"Orcs left: {string.Join(", ",stack)}");
                    Console.WriteLine();
                }
            if (stack.Count == 0)
            {

                {
                    Console.WriteLine("The people successfully repulsed the orc's attack.");
                    Console.Write($"Plates left: {string.Join(", ", plate)}");
                    Console.WriteLine();
                }
            }
        }
    }
}
