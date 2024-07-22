namespace AppendContentsToFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "C:\\Users\\swati.padmanabhan\\Desktop\\Training Weeks\\" +
                                "2ndWeek\\AppendContentsToFile\\TextFiles\\Username.txt";

            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine();

            AppendContentToFile(path, username);

            Console.WriteLine("Username Added Successfully");

        }
        static void AppendContentToFile(string path, string username)
        {
            //opening the file in append mode
            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(username);
            }
        }
    }
}
