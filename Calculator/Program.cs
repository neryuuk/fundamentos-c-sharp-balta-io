using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] _)
    {
      Multiplicacao();
    }

    static float LerValor(string prompt)
    {
      Console.WriteLine(prompt);
      return float.Parse(Console.ReadLine().Replace(',', '.'));
    }

    static void Soma()
    {
      float valor1 = LerValor("Primeiro valor:");
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

    static void Divisao()
    {
      float valor1 = LerValor("Primeiro valor:");
      float valor2 = LerValor("Segundo valor:");
      Console.WriteLine();
      Console.WriteLine($"{valor1} / {valor2} = {valor1 / valor2}");
      Console.ReadKey();
    }

    static void Multiplicacao()
    {
      float valor1 = LerValor("Primeiro valor:");
      float valor2 = LerValor("Segundo valor:");
      Console.WriteLine();
      Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
      Console.ReadKey();
    }
  }
}
