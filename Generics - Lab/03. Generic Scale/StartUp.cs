using System;

namespace GenericScale
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int left = 5;
            int right = 5;
            EqualityScale<int> equalityScale = new EqualityScale<int>(left, right);
             equalityScale.AreEqual();
            
        }
    }
}
