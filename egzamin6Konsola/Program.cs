namespace egzamin6Konsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst:");

            string? tekst = Console.ReadLine();

            Console.WriteLine("Liczba samogłosek w podanym tekście:");
            Console.WriteLine(BibliotekaNarzedziowa.LiczSamogloski(tekst));

            Console.WriteLine();

            Console.WriteLine("Tekst bez powtórzeń obok siebie:");
            Console.WriteLine(BibliotekaNarzedziowa.UsunPowtorzenia(tekst));


        }
    }
}
