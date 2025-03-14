namespace FredagÖvning
{
    public class Program
    {
        public static char FörstaIckeRepeterandeTecken(string text)
        {
            // Dictionary för att hålla koll på teckenfrekvenser
            Dictionary<char, int> teckenFrekvens = new Dictionary<char, int>();

            // Räkna varje tecken
            foreach (char tecken in text)
            {
                if (teckenFrekvens.ContainsKey(tecken))
                {
                    teckenFrekvens[tecken]++;
                }
                else
                {
                    teckenFrekvens[tecken] = 1;
                }
            }

            // Identifiera det första unika tecknet
            foreach (char tecken in text)
            {
                if (teckenFrekvens[tecken] == 1)
                {
                    return tecken;
                }
            }

            // Om inget unikt tecken hittas, returnera '_'
            return '_';
        }

        // Testfall
        public static void Main(string[] args)
        {
            Console.WriteLine(FörstaIckeRepeterandeTecken("swiss"));     // förväntade Output: w
            Console.WriteLine(FörstaIckeRepeterandeTecken("racecars")); // förväntade Output: e
            Console.WriteLine(FörstaIckeRepeterandeTecken("aabb"));     // förväntade Output: _
            Console.WriteLine(FörstaIckeRepeterandeTecken("abcabcde")); // förväntade Output: d
        }
    }
}

