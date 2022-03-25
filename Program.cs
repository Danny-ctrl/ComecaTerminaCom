using System;
namespace ComecaTerminaCom
{
  class Program
  {
    static void Main(string[] args)
    {
      var texto = "esse texto é um teste";

      System.Console.WriteLine(texto.StartsWith("Esse", StringComparison.OrdinalIgnoreCase));
      System.Console.WriteLine(texto.StartsWith("esse"));
      System.Console.WriteLine(texto.StartsWith("texto"));

      System.Console.WriteLine(texto.EndsWith("teste"));
      System.Console.WriteLine(texto.EndsWith("Teste"));
      System.Console.WriteLine(texto.EndsWith("nunca"));
    }
  }

}
