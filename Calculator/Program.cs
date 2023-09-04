using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] _)
    {
      Soma();
    }

    static float LerValor(string prompt, bool clear = false)
    {
      if (clear) Console.Clear();

      Console.WriteLine(prompt);
      return float.Parse(Console.ReadLine().Replace(',', '.'));
    }

    static void Soma()
    {
      float valor1 = LerValor("Primeiro valor:", true);
      float valor2 = LerValor("Segundo valor:");
      Console.WriteLine();
      Console.WriteLine($"A soma entre {valor1} e {valor2} é {valor1 + valor2}");
      Console.ReadKey();
    }
  }
}
