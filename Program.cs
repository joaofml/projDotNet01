using System.Text.Json;
using projDotNet01.Classes;
using projDotNet01.Repositories;

namespace meuPrimeiroProjetoDotNet
{
  public class Program
  {
    public static void Main()
    {
      AlunoRepository repositorio = new AlunoRepository();
      List<Aluno> listaAlunos = repositorio.listaAluno;

      string userOption = menu();
      while (userOption.ToUpper() != "S")
      {
        try
        {
          switch (userOption)
          {
            case "1":
              listaAlunos.Add(NovoAluno());
              break;
            case "2":
              if(listaAlunos.Count==0)
              {
                System.Console.WriteLine("Nenhum registros");
              }
              foreach(Aluno a in listaAlunos)
              {
                System.Console.WriteLine(a);
              }
              break;
            case "3":
              System.Console.WriteLine("index: ");
              int index = int.Parse(Console.ReadLine());
              AtualizaAluno(ref listaAlunos, index);
              break;
            case "4":
              System.Console.WriteLine("Deletar. index: ");
              index = int.Parse(Console.ReadLine());
              DeletarAluno(ref listaAlunos,index);
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
      File.WriteAllText("./Repositories/db.json",JsonSerializer.Serialize(listaAlunos));
      Console.WriteLine("Aplication finished with success");
    }
    private static string menu()
    {
      Console.WriteLine("1 - Cadastrar aluno");
      Console.WriteLine("2 - Pesquisar aluno");
      Console.WriteLine("3 - Atualizar aluno");
      Console.WriteLine("4 - Deletar aluno");
      Console.WriteLine("s - Sair ");

      string userOption = Console.ReadLine().ToUpper();
      return userOption;
    }
    private static Aluno NovoAluno()
    {
      System.Console.WriteLine("Cadastro: ");
      int cadastro = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Nome: ");
      string nome = (Console.ReadLine());
      System.Console.WriteLine("Nota: ");
      double nota = double.Parse(Console.ReadLine());
      Aluno aluno = new Aluno(cadastro,nome,nota);
      return aluno;
    }
    private static void AtualizaAluno(ref List<Aluno> alunos,int index)
    {
      System.Console.WriteLine("Atualizar aluno");
      System.Console.WriteLine("Cadastro: ");
      alunos[index].cadastro = int.Parse(Console.ReadLine());
      System.Console.WriteLine("Nome: ");
      alunos[index].nome = (Console.ReadLine());
      System.Console.WriteLine("Nota: ");
      alunos[index].nota = double.Parse(Console.ReadLine());
    }
    private static void DeletarAluno(ref List<Aluno> alunos, int index)
    {
      System.Console.WriteLine("Removido");
      System.Console.WriteLine(alunos[index]);
      alunos.Remove(alunos[index]);
    }
  }//Classe
}//Namespace