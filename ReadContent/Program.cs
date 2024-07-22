namespace ReadContentFromFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string textFilePath = "C:\\Users\\swati.padmanabhan\\Desktop\\Training Weeks\\" +
                                        "2ndWeek\\ReadContentFromFile\\TextFiles\\Fruits.txt";

            const string htmlFilePath = "C:\\Users\\swati.padmanabhan\\Desktop\\Training Weeks\\" +
                                        "2ndWeek\\ReadContentFromFile\\HTMLFiles\\Sample.html";

            ReadContentFromFiles(textFilePath, "Text File");
            ReadContentFromFiles(htmlFilePath, "HTML File");

        }

        static void ReadContentFromFiles(string filePath, string fileType)
        {
            StreamReader reader = new StreamReader(filePath);
            string line = reader.ReadLine();
            Console.WriteLine($"====================Reading Content from {fileType}====================");
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }

        }

    }
}
