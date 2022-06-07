using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            string firstDateAsStr = Console.ReadLine();
            string secondDateAsStr = Console.ReadLine();

            DateModifier currentModif = new DateModifier();

            currentModif.Difference = DateModifier.GetDifferenceBetweenDates(firstDateAsStr, secondDateAsStr);

            Console.WriteLine(currentModif.Difference);
        }
    }
}
