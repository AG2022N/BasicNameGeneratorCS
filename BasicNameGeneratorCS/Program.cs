using System.Text;

//These need to be in the debug folder/net7.0, during development, or the folder containing the executable on release
string maleOutput = @"Output\\OutputMale.txt";
string femaleOutput = @"Output\\OutputFemale.txt";

int UserInput = 0;
while (UserInput != 3)
{
    int maxGen, Counter = 0;
    Console.Clear();

    Console.SetCursorPosition(0, 1);
    Console.Write("     Type '1' to generate male names\n" +
                  "     Type '2' to generate female names\n" +
                  "     Type '3' to exit");
    Console.SetCursorPosition(5, 27);
    Console.Write("Choose: ");
    UserInput = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    if (UserInput >= 3 || UserInput <= 0)
    {
        Environment.Exit(0);
    }

    Console.SetCursorPosition(5, 1);
    Console.Write("Type the number of names to generate: ");
    maxGen = Convert.ToInt32(Console.ReadLine());
    Console.Clear();

    while (UserInput == 1 && Counter != maxGen)
    {
        string randomName = BasicNameGeneratorCS.NameGenerator.GenerateNameMale();
        StreamWriter sw = new StreamWriter(maleOutput, true, Encoding.ASCII);
        sw.WriteLine(randomName);
        sw.Close();
        Console.WriteLine(randomName);
        Counter++;
    }
    while (UserInput == 2 && Counter != maxGen)
    {
        string randomName = BasicNameGeneratorCS.NameGenerator.GenerateNameFemale();
        StreamWriter sw = new StreamWriter(femaleOutput, true, Encoding.ASCII);
        sw.WriteLine(randomName);
        sw.Close();
        Console.WriteLine(randomName);
        Counter++;
    }
    Console.ReadKey();
}