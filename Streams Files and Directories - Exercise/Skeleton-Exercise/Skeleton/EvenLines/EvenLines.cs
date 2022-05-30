namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {


                using (var writer = new StreamWriter("../../../Output.txt"))
                {
                    int counter = 0;

                    string line = reader.ReadLine();

                    while (line != null)
                    {
                        if (counter % 2 == 0)
                        {
                            line = Regex.Replace(line, @"[-,.!?]", "@");

                            writer.WriteLine(string.Join(" ",
                                line
                                .Split(" ")
                                .Reverse()));
                        }

                        line = reader.ReadLine();
                        counter++;
                    }
                    return line;
                }
                
                
            }
            
        }
    }
}

