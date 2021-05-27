using System;
using System.Collections.Generic;
using TrabalhandoNoConsole.Compartilhado;
using TrabalhandoNoConsole.Funcionalidades.Objetos;

namespace TrabalhandoNoConsole.Funcionalidades
{
    public static class Exercicio4AlunosAprovados
    {
        private static bool finalizarPreenchimentoAlunos = false;

        public static bool SolicitarPreenchementoDeValoresParaOUsuario()
        {
            var alunos = SolicitarPreenchimentoDeAlunos();
            ImprimirAlunosAprovados(alunos);

            return ValidadorProximoPassoFluxo.ValidarSeUsuarioContinuaraPrograma();
        }

        private static List<Aluno> SolicitarPreenchimentoDeAlunos()
        {
            var alunos = new List<Aluno>();
            int contadorAluno = 1;

            while (!finalizarPreenchimentoAlunos)
            {
                var novoAluno = new Aluno();

                Console.WriteLine(MensagensGerais.FormatarMensagem(MensagensGerais.MsgNomeAluno, contadorAluno.ToString()));
                var nome = Console.ReadLine();
                novoAluno.PreencherNome(nome);

                SolicitarPreenchimentoDeNotas(novoAluno);

                alunos.Add(novoAluno);
                contadorAluno++;
            }

            return alunos;
        }

        private static void SolicitarPreenchimentoDeNotas(Aluno novoAluno)
        {
            var finalizarPreenchimentoDeNotas = false;
            var contadorNota = 1;

            Console.WriteLine(MensagensGerais.MsgFinalizarNotas);

            while (!finalizarPreenchimentoDeNotas)
            {
                Console.WriteLine(MensagensGerais.FormatarMensagem(MensagensGerais.MsgNotaAluno, contadorNota.ToString(), novoAluno.Nome));
                var nota = Console.ReadLine();
                var notaFormatada = nota.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
                decimal notaCorreta;

                finalizarPreenchimentoDeNotas = VerificarSeDevePararPreenchimentoNotas(nota);
                if (finalizarPreenchimentoDeNotas)
                    return;

                while (!decimal.TryParse(notaFormatada, out notaCorreta))
                {
                    Console.WriteLine(MensagensGerais.MsgNotaInvalida);
                    nota = Console.ReadLine();
                    notaFormatada = nota.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
                }

                novoAluno.PreencherNota(notaCorreta);
                contadorNota++;
            }
        }

        private static bool VerificarSeDevePararPreenchimentoNotas(string nota)
        {
            var resultado = false;

            if (nota == "/fimN")
                resultado = true;

            if (nota == "/fimA")
            {
                finalizarPreenchimentoAlunos = true;
                resultado = true;
            }

            return resultado;
        }

        private static void ImprimirAlunosAprovados(List<Aluno> alunos)
        {
            Console.WriteLine(MensagensGerais.MsgResultadoCabecalho);
            Console.WriteLine(MensagensGerais.MsgNotasAcimaDe7);
            alunos.ForEach(aluno =>
            {
                if (aluno.Media > 7)
                    Console.WriteLine(MensagensGerais.FormatarMensagem(MensagensGerais.MsgAlunoMedia, aluno.Nome, aluno.Media.ToString()));
            });
        }
    }
}
