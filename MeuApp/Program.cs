using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] _)
    {
      MeuMetodo();
      Console.WriteLine(RetornaNome("Nelson", "Antunes"));
    }

    static void MeuMetodo()
    {
      string text = "Hell-o, World!";
      Console.WriteLine(text);
    }

    static string RetornaNome(string nome, string sobrenome, int? idade = null)
    {
      return $"{nome} {sobrenome}";
    }
  }
}
