namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            string[] fileOne = File.ReadAllLines(firstInputFilePath);
            string[] fileTwo = File.ReadAllLines(secondInputFilePath);

            using (StreamWriter writer = File.CreateText(outputFilePath))
            {
                int lineNum = 0;

                while (lineNum < fileOne.Length || lineNum < fileTwo.Length)
                {
                    if (lineNum < fileOne.Length)
                        writer.WriteLine(fileOne[lineNum]);
                    if (lineNum < fileTwo.Length)
                        writer.WriteLine(fileTwo[lineNum]);
                    lineNum++;
                }
            }
        }
    }
}
