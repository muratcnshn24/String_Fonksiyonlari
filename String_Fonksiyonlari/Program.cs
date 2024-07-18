using System;

namespace String_Fonksiyonlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string ifade = " Afacan";

            Console.WriteLine(ifade);
            Console.WriteLine(ifade.Length);
            Console.WriteLine(ifade.Trim());
            Console.WriteLine(ifade.Trim().Length);
            Console.WriteLine(ifade.TrimStart());
            Console.WriteLine(ifade.TrimEnd());
            Console.WriteLine(ifade.ToLower());
            Console.WriteLine(ifade.ToUpper());
            Console.WriteLine(ifade.Replace('a', 'e'));
        }
    }
}
