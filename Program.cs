using System.Text.RegularExpressions;

namespace AtividadeJaimeM2S5Exer2
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Funcionario funcionario = new Funcionario("1","dayane");

      try
      {
        ValidaId(funcionario);
        ValidaNome(funcionario);
        MostrarNomeFuncionario(funcionario);
      }
      catch (Exception ex)
      {

        Console.WriteLine($"Erro: {ex.Message}");
      }

    }
    public static void MostrarNomeFuncionario(Funcionario funcionario)
    {
      if(funcionario == null)
      {
      throw new NullReferenceException("O objeto funcionario é nulo");
      }
      Console.WriteLine($"Nome{funcionario.Nome}");
    }

    public static void ValidaNome(Funcionario nome)
    {
      Regex regex = new Regex ("^[a-zA-Z]+$");
      if(!regex.IsMatch(nome.Nome))
        throw new NomeDoFuncionarioInvalidoException(nome.Nome);
    }
    public static void ValidaId(Funcionario id)
    {
      Regex regex = new Regex("^[0-9]+$");
      if (!regex.IsMatch(id.Id))
        throw new IdDoFuncionarioInvalidoException(id.Id);
    }
  }
}