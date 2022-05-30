﻿namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            using (var reader = new StreamReader(inputFilePath))
            {


                using (var writer = new StreamWriter(outputFilePath))
                {
                    int counter = 1;

                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine($"{counter}. {line}");

                        line = reader.ReadLine();
                        counter++;
                    }
                }

            }
        }
    }
}
