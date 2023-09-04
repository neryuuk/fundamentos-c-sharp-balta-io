using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] _)
    {
      while (true) Menu();
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

    static void Multiplicacao()
    {
      float valor1 = LerValor("Primeiro valor:");
      float valor2 = LerValor("Segundo valor:");
      Console.WriteLine();
      Console.WriteLine($"{valor1} * {valor2} = {valor1 * valor2}");
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

    static void Menu()
    {
      Console.Clear();
      Console.WriteLine("┌──────────────────────┐");
      Console.WriteLine("│  Escolha a operação: │");
      Console.WriteLine("│                      │");
      Console.WriteLine("│             Sair [0] │");
      Console.WriteLine("│             Soma [1] │");
      Console.WriteLine("│        Subtração [2] │");
      Console.WriteLine("│    Multiplicação [3] │");
      Console.WriteLine("│          Divisão [4] │");
      Console.WriteLine("└──────────────────────┘");

      short operacao;
      try
      {
        operacao = short.Parse(Console.ReadLine());
        switch (operacao)
        {
          case 0: Environment.Exit(0); break;
          case 1: Soma(); break;
          case 2: Subtracao(); break;
          case 3: Multiplicacao(); break;
          case 4: Divisao(); break;
          default: throw new Exception();
        }
      }
      catch
      {
        Console.WriteLine("Opção inválida! Pressione Enter e escolha novamente.");
        Console.ReadKey();
      }
    }
  }
}
