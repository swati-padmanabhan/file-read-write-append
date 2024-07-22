namespace WriteContentToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteContentToTextFile();
            WriteContentToHTMLFile();
        }

        //Method to write weather conditions in text file
        static void WriteContentToTextFile()
        {
            //File path for text file
            const string textFilePath = "C:\\Users\\swati.padmanabhan\\Desktop\\Training Weeks\\" +
                                "2ndWeek\\WriteContentToFile\\TextFiles\\Weather.txt";

            //StreamWriter to write to this file
            StreamWriter writer = new StreamWriter(textFilePath);

            string[] contentOnText = { "Sunny", "Rainy", "Cloudy", "Windy", "Snowy" };

            foreach (string content in contentOnText)
            {
                writer.WriteLine(content);
            }
            Console.WriteLine("Text File Added Successfully !");
            writer.Close();
        }


        //Method to write weather conditions in HTML file
        static void WriteContentToHTMLFile()
        {
            const string path = "C:\\Users\\swati.padmanabhan\\Desktop\\Training Weeks\\" +
                               "2ndWeek\\WriteContentToFile\\TextFiles\\Weather.html";
            string htmlContent = @"
                                <html>
                                <head>
                                    <title>Weather Report</title>
                                </head>
                                <body>
                                    <h1>Weather Conditions</h1>
                                    <ul>
                                        <li>Sunny</li>
                                        <li>Rainy</li>
                                        <li>Cloudy</li>
                                        <li>Windy</li>
                                        <li>Snowy</li>
                                    </ul>
                                </body>
                                </html>";
            //Write the HTML content to the file
            File.WriteAllText(path, htmlContent);
            Console.WriteLine("HTML File Added Successfully !");
        }
    }
}
