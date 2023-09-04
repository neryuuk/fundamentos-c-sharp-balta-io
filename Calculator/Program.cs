using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] _)
    {
      Soma();
      Console.WriteLine();
      Subatracao();
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
      Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
      Console.ReadKey();
    }

    static void Subtracao()
    {
      float valor1 = LerValor("Primeiro valor:");
      float valor2 = LerValor("Segundo valor:");
      Console.WriteLine();
      Console.WriteLine($"{valor1} - {valor2} = {valor1 - valor2}");
      Console.ReadKey();
    }
  }
}
