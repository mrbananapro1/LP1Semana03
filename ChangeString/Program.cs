using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva algo");
            string phrase = Console.ReadLine();

            Console.WriteLine("Escreva uma letra");
            string letra = Console.ReadLine();

            string x = ("x");
            
            phrase = phrase.Replace(letra, x);

            Console.WriteLine("Frase:" + phrase);
        }
    }
}
