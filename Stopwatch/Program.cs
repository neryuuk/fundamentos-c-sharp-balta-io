using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace Stopwatch
{
  internal class Program
  {
    static void Main(string[] _)
    {
      while (true) Menu();
    }

    static void Start(int time, char unit = 'S')
    {
      int current = 0;

      while (current < time)
      {
        Console.Clear();
        current++;
        Console.WriteLine(current);
        Thread.Sleep(1000 * (unit == 'S' ? 1 : 60));
      }

      Console.Clear();
      Console.WriteLine("Cronômetro finalizado! Pressione Enter para voltar ao Menu.");
      Console.ReadKey();
    }

    public static void Menu()
    {
      Console.Clear();
      Console.WriteLine("┌─────────────────────────────┐");
      Console.WriteLine("│  Opções:                    │");
      Console.WriteLine("│                             │");
      Console.WriteLine("│                    Sair [0] │");
      Console.WriteLine("│      Contar em segundos [S] │");
      Console.WriteLine("│       Contar em minutos [M] │");
      Console.WriteLine("│                             │");
      Console.WriteLine("│ Quanto tempo deseja contar? │");
      Console.WriteLine("│                             │");
      Console.WriteLine("│ Ex.: 20s, 15m, 8m, etc      │");
      Console.WriteLine("└─────────────────────────────┘");

      try
      {
        string input = Console.ReadLine().Trim().ToUpper();

        if (input == "0") Environment.Exit(0);
        Regex regex = new Regex(@"^([0-9]+)([S|M])$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

        if (!regex.IsMatch(input)) throw new Exception();

        Start(
          int.Parse(regex.Matches(input)[0].Groups[1].Value),
          char.Parse(regex.Matches(input)[0].Groups[2].Value)
        );
      }
      catch
      {
        Console.WriteLine("Opção inválida! Pressione Enter e escolha novamente.");
        Console.ReadKey();
      }
    }
  }
}
