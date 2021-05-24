namespace TrabalhandoNoConsole.Funcionalidades.Objetos
{
    public class FuncionarioSalario
    {
        public string Nome { get; private set; }
        public decimal Salario { get; private set; }

        public FuncionarioSalario() { }

        public FuncionarioSalario(string nome, decimal salario)
        {
            this.Nome = nome;
            this.Salario = salario;
        }

        public void PreencherNome(string nome)
        {
            this.Nome = nome;
        }

        public void PreencherSalario(decimal salario)
        {
            this.Salario = salario;
        }
    }
}
