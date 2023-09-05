using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
  class Program
  {
    static void Main(string[] _)
    {
      while (true) Menu();
    }

    static List<float> LerValores()
    {
      List<float> valores = new List<float>();
      bool continua = true;
      while (continua)
      {
        try
        {
          Console.WriteLine("Digite um valor numérico e dê 'Enter'. Após inserir 2 ou mais valores, digite '=' para calcular.");
          string input = Console.ReadLine().Trim().Replace(',', '.');
          if (input == "=") continua = false;
          else valores.Add(float.Parse(input));
        }
        catch
        {
          Console.WriteLine("Valor inválido.");
        }
      }

      if (valores.Count < 2) throw new Exception();
      return valores;
    }

    static void Soma()
    {
      List<float> valores = LerValores();
      Console.WriteLine();

      Console.WriteLine($"{string.Join(" + ", valores)} = {valores.Sum()}");
      Console.ReadKey();
    }

    static void Subtracao()
    {
      List<float> valores = LerValores();
      Console.WriteLine();

      float resultado = valores[0];

      for (int i = 1; i < valores.Count; i++)
      {
        resultado -= valores[i];
      }

      Console.WriteLine($"{string.Join(" - ", valores)} = {resultado}");
      Console.ReadKey();
    }

    static void Multiplicacao()
    {
      List<float> valores = LerValores();
      Console.WriteLine();

      float resultado = valores[0];

      for (int i = 1; i < valores.Count; i++)
      {
        resultado *= valores[i];
      }

      Console.WriteLine($"{string.Join(" * ", valores)} = {resultado}");
      Console.ReadKey();
    }

    static void Divisao()
    {
      List<float> valores = LerValores();
      Console.WriteLine();

      float resultado = valores[0];

      for (int i = 1; i < valores.Count; i++)
      {
        resultado /= valores[i];
      }

      Console.WriteLine($"{string.Join(" / ", valores)} = {resultado}");
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

      try
      {
        switch (short.Parse(Console.ReadLine()))
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
