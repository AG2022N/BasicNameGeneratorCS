using System.Text;

while (true)
{
    //These need to be in the debug folder/net7.0, during development, or the folder containing the executable on release
    string maleOutput = @"Output\\OutputMale.txt", femaleOutput = @"Output\\OutputFemale.txt";
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
            Console.SetCursorPosition(5, 1);                                            //put this into repeateable method
            Console.Write("Type the number of names to generate: ");
            bool MaxGenParse1 = Int32.TryParse(Console.ReadLine(), out MaxGen);
            Console.Clear();
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
            Console.SetCursorPosition(5, 1);
            Console.Write("Type the number of names to generate: ");
            bool MaxGenParse2 = Int32.TryParse(Console.ReadLine(), out MaxGen);
            Console.Clear();
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
        default:
            Console.SetCursorPosition(5, 1);
            Console.Write("Invalid input, press enter to try again:");
            break;
    }
    Console.ReadKey();
}