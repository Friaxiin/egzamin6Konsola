namespace egzamin6Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BibliotekaNarzedziowa.LiczSamogloski("Abba;;;to zespół ");
            Console.WriteLine(BibliotekaNarzedziowa.licznik);

            BibliotekaNarzedziowa.UsunPowtorzenia("Abba;;;to zespół ");
            Console.WriteLine(BibliotekaNarzedziowa.napisWyjsciowy);
        }
    }
}
