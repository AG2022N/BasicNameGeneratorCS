using System.Text;
using System.IO;

namespace BasicNameGeneratorCS
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                string maleOutput = @"Output\\OutputMale.txt", femaleOutput = @"Output\\OutputFemale.txt";
                string[] namesMale = File.ReadAllLines(@"Data\\NamesMale.txt");
                string[] namesFemale = File.ReadAllLines(@"Data\\NamesFemale.txt");
                string[] namesLast = File.ReadAllLines(@"Data\\LastNames.txt");
                if (!File.Exists(maleOutput)) { File.Create(maleOutput).Close();}
                if (!File.Exists(femaleOutput)) { File.Create(femaleOutput).Close();}

                int UserInput, MaxGen, Counter = 0;
                Console.Clear();
                Console.SetCursorPosition(0, 1);
                Console.Write("     Type '1' to generate male names\n" +
                              "     Type '2' to generate female names\n");
                Console.SetCursorPosition(5, 27);
                Console.Write("Choose: ");
                bool UserInputParse = Int32.TryParse(Console.ReadLine(), out UserInput);
                Console.Clear();

                switch (UserInput)
                {
                    case 1:
                        Console.SetCursorPosition(5, 1);
                        Console.Write("Type the number of names to generate: ");
                        bool MaxGenParse1 = Int32.TryParse(Console.ReadLine(), out MaxGen);
                        Console.Clear();
                        while (Counter != MaxGen)
                        {
                            string randomName = GenerateName(namesMale, namesLast);
                            var WriteToFile = new StreamWriter(maleOutput, true, Encoding.ASCII);
                            WriteToFile.WriteLine(randomName);
                            WriteToFile.Close();
                            Console.WriteLine("     " + randomName);
                            Counter++;
                        }
                        break;
                    case 2:
                        Console.SetCursorPosition(5, 1);
                        Console.Write("Type the number of names to generate: ");
                        bool MaxGenParse2 = Int32.TryParse(Console.ReadLine(), out MaxGen);
                        Console.Clear();
                        while (Counter != MaxGen)
                        {
                            string randomName = GenerateName(namesFemale, namesLast);
                            var WriteToFile = new StreamWriter(femaleOutput, true, Encoding.ASCII);
                            WriteToFile.WriteLine(randomName);
                            WriteToFile.Close();
                            Console.WriteLine("     " + randomName);
                            Counter++;
                        }
                        break;
                    default:
                        Console.SetCursorPosition(5, 1);
                        Console.Write("Invalid input, press enter to try again:");
                        break;
                }
                Console.ReadKey();
            }
            static string GenerateName(string[] firstNames, string[]lastNames)
            {
                Random rand = new Random();
                string randomFirstName = firstNames[rand.Next(firstNames.Length)];
                string randomLastName = lastNames[rand.Next(lastNames.Length)];
                return $"{randomFirstName} {randomLastName}";
            }
        }
    }
}