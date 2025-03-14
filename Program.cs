namespace FredagÖvning
{
    public class Program
    {
        public static List<List<string>> GrupperaAnagram(List<string> ordLista)
        {
            // Dictionary för att gruppera anagram
            Dictionary<string, List<string>> anagramDictionary = new Dictionary<string, List<string>>();

            // Iterera genom orden
            foreach (string ord in ordLista)
            {
                // Sortera bokstäverna i ordet och skapa en unik nyckel utan String.Concat()
                string sorteratOrd = string.Join("", ord.OrderBy(tecken => tecken));

                // Lägg till i Dictionaryn
                if (anagramDictionary.ContainsKey(sorteratOrd))
                {
                    anagramDictionary[sorteratOrd].Add(ord);
                }
                else
                {
                    anagramDictionary[sorteratOrd] = new List<string> { ord };
                }
            }

            // Konvertera Dictionaryn till en lista med grupper
            return anagramDictionary.Values.ToList();
        }

        // Testfall
        public static void Main(string[] args)
        {
            var input = new List<string> { "listen", "silent", "enlist", "rat", "tar", "art", "evil", "vile", "live" };
            var resultat = GrupperaAnagram(input);

            // Skriv ut resultatet
            foreach (var grupp in resultat)
            {
                Console.WriteLine(string.Join(", ", grupp));
            }
        }
    }
}
