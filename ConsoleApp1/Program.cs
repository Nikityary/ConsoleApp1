internal class Program
{
    private static void Main(string[] args)
    {
        char[] a = { 'ё', 'у', 'е', 'ы', 'а', 'а', 'о', 'э', 'я', 'и', 'ю' };
        Console.WriteLine(Console.ReadLine().ToCharArray().Count(b => a.Contains(b)));
    }
}