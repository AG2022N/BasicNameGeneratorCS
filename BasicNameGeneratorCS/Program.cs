using System.Text;

while (true)
{
    //These need to be in the debug folder/net7.0, during development, or the folder containing the executable on release
    string maleOutput = @"Output\\OutputMale.txt", femaleOutput = @"Output\\OutputFemale.txt";
    int UserInput, MaxGen, Counter = 0;
    Console.Clear();

    Console.SetCursorPosition(0, 1);
    Console.Write("     Type '1' to generate male names\n" +
                  "     Type '2' to generate female names\n" +
                  "     Type any unlisted character to exit");
    Console.SetCursorPosition(5, 27);
    Console.Write("Choose: ");
    bool UserInputParse = Int32.TryParse(Console.ReadLine(), out UserInput);
    Console.Clear();

    if (UserInput > 2 || UserInput <= 0)
    {
        Environment.Exit(0);
    }

    Console.SetCursorPosition(5, 1);
    Console.Write("Type the number of names to generate: ");
    bool MaxGenParse = Int32.TryParse(Console.ReadLine(), out MaxGen);
    Console.Clear();

    switch (UserInput)
    {
        case 1:
            while (Counter != MaxGen)
            {
                string randomName = BasicNameGeneratorCS.NameGenerator.GenerateNameMale();
                var WriteToFile = new StreamWriter(maleOutput, true, Encoding.ASCII);
                WriteToFile.WriteLine(randomName);
                WriteToFile.Close();
                Console.WriteLine("     " + randomName);
                Counter++;
            }
            break;
        case 2:
            while (Counter != MaxGen)
            {
                string randomName = BasicNameGeneratorCS.NameGenerator.GenerateNameFemale();
                var WriteToFile = new StreamWriter(femaleOutput, true, Encoding.ASCII);
                WriteToFile.WriteLine(randomName);
                WriteToFile.Close();
                Console.WriteLine("     " + randomName);
                Counter++;
            }
            break;
    }
    Console.ReadKey();
}