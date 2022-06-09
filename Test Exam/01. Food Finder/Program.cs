using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Food_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";
            List<char> pear1 =new List<char>(pear.ToCharArray());
            List<char> flour1 = new List<char>(flour.ToCharArray());
            List<char> pork1 = new List<char>(pork.ToCharArray());
            List<char> olive1 = new List<char>(olive.ToCharArray());

            Queue<char> queue = new Queue<char>(Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));
            Stack<char> stack = new Stack<char>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse));

            while (stack.Count >0)
            {
                char vowels = queue.Dequeue();
                queue.Enqueue(vowels);
                char consonants = stack.Pop();
                if (pear1.Contains(vowels))
                {
                    pear1.Remove(vowels);
                }
                if (flour1.Contains(vowels))
                {
                    flour1.Remove(vowels);
                }
                if (pork1.Contains(vowels))
                {
                    pork1.Remove(vowels);
                }
                if (olive1.Contains(vowels))
                {
                    olive1.Remove(vowels);
                }
                if (pear1.Contains(consonants))
                {
                    pear1.Remove(consonants);
                }
                if (flour1.Contains(consonants))
                {
                    flour1.Remove(consonants);
                }
                if (pork1.Contains(consonants))
                {
                    pork1.Remove(consonants);
                }
                if (olive1.Contains(consonants))
                {
                    olive1.Remove(consonants);
                }
            }
            List<string> list = new List<string>();
            if (pear1.Count == 0)
            {
                list.Add(pear);
            }
            if (flour1.Count == 0)
            {
                list.Add(flour);
            }
            if (pork1.Count == 0)
            {
                list.Add(pork);
            }
            if (olive1.Count == 0)
            {
                list.Add(olive);
            }
            Console.WriteLine($"Words found: {list.Count}");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
