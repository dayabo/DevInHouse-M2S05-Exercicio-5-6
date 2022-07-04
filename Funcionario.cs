namespace AtividadeJaimeM2S5Exer2
{
 public class Funcionario
  {
    public string Id;
    public string Nome;
    public Funcionario(){}
    public Funcionario(string id, string nome)
    {
      Id = id;
      Nome = nome;
    }
  }

  [Serializable]
  public class NomeDoFuncionarioInvalidoException : Exception
  {
    public NomeDoFuncionarioInvalidoException()
    { }
    public NomeDoFuncionarioInvalidoException(string nome)
    : base(String.Format($"Nome do funcionario inválido {nome}"))
    { }
  }

  [Serializable]
  public class  IdDoFuncionarioInvalidoException : Exception
  {
    public IdDoFuncionarioInvalidoException()
    { }
    public IdDoFuncionarioInvalidoException(string id)
    : base(String.Format($"Id do funcionario inválido  {id}"))
    { }
  }
}