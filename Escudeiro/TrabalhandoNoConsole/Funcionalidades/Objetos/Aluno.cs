using System.Collections.Generic;
using System.Linq;

namespace TrabalhandoNoConsole.Funcionalidades.Objetos
{
    public class Aluno
    {
        public string Nome { get; private set; }
        public List<decimal> Notas { get; private set; } = new List<decimal>();
        public decimal Media { get { return (Notas.Sum() / Notas.Count()); } }

        public Aluno() { }

        public Aluno(string nome)
        {
            this.Nome = nome;
        }

        public void PreencherNome(string nome)
        {
            this.Nome = nome;
        }

        public void PreencherNota(decimal nota)
        {
            this.Notas.Add(nota);
        }
    }
}
