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
      Product mouse = new Product(1, "Mouse Gamer", 219.95);
      return $"{nome} {sobrenome}";
    }
  }

  struct Product
  {
    public int Id;
    public string Title;
    public double Price;

    public Product(int id, string title, double price)
    {
      Id = id;
      Title = title;
      Price = price;
    }

    public readonly double PriceInDollar(double dollar)
    {
      return Price * dollar;
    }
  }
}
