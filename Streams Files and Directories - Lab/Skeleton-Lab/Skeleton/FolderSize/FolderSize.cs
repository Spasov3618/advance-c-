namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            var dir = new DirectoryInfo(folderPath);

            long size = 0;

            foreach (var fileInfo in dir.GetFiles())
            {
                size += fileInfo.Length;
            }

            using (var writer = new StreamWriter(outputFilePath))
            {
                writer.WriteLine($"{(double)size / 1024 / 1024} MB");
            }
        }
    }
}
