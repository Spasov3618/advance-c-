using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Birthday_Celebration
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Queue<int> guest = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> plate = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int food = 0;
            while (guest.Count >0 && plate.Count>0)
            {
                int currGuest = guest.Peek();
                int currPlate = plate.Peek();
                if (currPlate>=currGuest)
                {
                    food += currPlate - currGuest;
                    plate.Pop();
                    guest.Dequeue();
                    
                }
               
                if (currGuest > currPlate)
                {
                    guest.Dequeue();
                    plate.Pop();
                                       
                    guest = new Queue<int>(guest.Reverse());
                    guest.Enqueue(currGuest - currPlate);
                    guest = new Queue<int>(guest.Reverse());
                }
            }
            if (guest.Count == 0)
            {
              
                    Console.WriteLine($"Plates: {string.Join(" ", plate)}");

              
                

                
            }
            else if (plate.Count==0)
            {
                

                Console.WriteLine($"Guests: {string.Join(" ", guest)}");
                
            }
            Console.WriteLine($"Wasted grams of food: {food}");
        }
    }
}
