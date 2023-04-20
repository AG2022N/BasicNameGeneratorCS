namespace BasicNameGeneratorCS
{
    public class NameGenerator
    {
        public static string[] namesMale = File.ReadAllLines(@"Data\\NamesMale.txt");
        public static string[] namesFemale = File.ReadAllLines(@"Data\\NamesFemale.txt");
        public static string[] lastNames = File.ReadAllLines(@"Data\\LastNames.txt");
        static readonly Random rand = new Random();
        public static string GenerateNameMale()
        {
            string randomFirstName = namesMale[rand.Next(namesMale.Length)];
            string randomLastName = lastNames[rand.Next(lastNames.Length)];
            return $"{randomFirstName} {randomLastName}";
        }
        public static string GenerateNameFemale()
        {
            string randomFirstName = namesFemale[rand.Next(namesFemale.Length)];
            string randomLastName = lastNames[rand.Next(lastNames.Length)];
            return $"{randomFirstName} {randomLastName}";
        }
    }
}