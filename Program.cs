using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "Gustavo ";
            string sobrenome = "Henrique";
            //Console.WriteLine(string.Concat(nome, sobrenome));
            //Console.WriteLine($"{nome}{sobrenome}");

            //Console.WriteLine(nome[3]);
            
            string nomeCompleto = $"{nome}{sobrenome}";
            Console.WriteLine(nomeCompleto);
            //Console.WriteLine(nome.IndexOf("1"));

            int posicao = nomeCompleto.IndexOf("G"); // = ("H");
            //Pegar o sobrenome
            string nomeFinal = nomeCompleto.Substring(posicao);
            Console.WriteLine(nomeFinal);
            Console.WriteLine(nomeFinal.ToUpper());
            Console.WriteLine(nomeFinal.ToLower());

        }
    }
}