using System;

namespace _9._161
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b, c;
            Console.Write("Введите слова (разделитель пробел):");
            a = Console.ReadLine();

            Console.WriteLine("1) повторяющиеся буквы каждого слова рассматриваются.");

            string[] slovos = a.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (string slovo in slovos)
            {
                b = a.Replace(slovo, "");
                for (int i = 0; i < slovo.Length; i++)
                    if (!b.Contains(slovo[i], StringComparison.OrdinalIgnoreCase))
                        Console.Write(slovo[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("2) повторяющиеся буквы каждого слова не рассматриваются.");
            foreach (string slovo in slovos)
            {
                b = a.Replace(slovo, "");
                c = String.Empty;
                for (int i = 0; i < slovo.Length; i++)
                    if (!c.Contains(slovo[i], StringComparison.OrdinalIgnoreCase))
                    {
                        c += slovo[i];
                        if (!b.Contains(slovo[i], StringComparison.OrdinalIgnoreCase))
                            Console.Write(slovo[i] + " ");
                    }
            }
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
