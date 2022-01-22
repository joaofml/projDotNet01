
using System;
namespace meuPrimeiroProjetoDotNet
{

  public class Program
  {
    public static void Main()
    {
      string? userOption = menu();
      while (userOption?.ToUpper() != "S")
      {
        try
        {
          switch (userOption)
          {
            case "1":
              Console.WriteLine("1()");
              break;
            case "2":
              Console.WriteLine("2()");
              break;
            case "3":
              Console.WriteLine("3()");
              break;
            case "4":
              Console.WriteLine("4()");
              break;
            default:
              throw new Exception("Invalid command");
          }
        }
        catch (Exception)
        {
          // Console.Clear();
          Console.WriteLine("Opção Invalida");
          Console.Beep(400, 300);
        }
        userOption = menu();
      }
      Console.WriteLine("Aplication finished with success");
    }
    private static string? menu()
    {
      Console.WriteLine("1 - Cadastrar aluno");
      Console.WriteLine("2 - Pesquisar aluno");
      Console.WriteLine("3 - Atualizar aluno");
      Console.WriteLine("4 - Deletar aluno");
      Console.WriteLine("s - Sair ");

      string? userOption = Console.ReadLine();
      return userOption;
    }
  }


}



