using System;
using TrabalhandoNoConsole.Compartilhado;
using TrabalhandoNoConsole.Funcionalidades.Objetos;

namespace TrabalhandoNoConsole.Funcionalidades
{
    public static class Exercicio2Salarios
    {
        public static bool SolicitarPreenchementoDeValoresParaOUsuario()
        {
            int quantidadeDeFuncionariosInt = 0;

            while (quantidadeDeFuncionariosInt <= 0)
            {
                Console.WriteLine(MensagensGerais.MsgInformandoComoFuncionaALeituraDeSalarios);
                Console.WriteLine(MensagensGerais.MsgSolicitarQuantidadeDeFuncionarios);
                var quantidadeDeFuncionarios = Console.ReadLine();

                if (!int.TryParse(quantidadeDeFuncionarios, out quantidadeDeFuncionariosInt))
                    Console.WriteLine(MensagensGerais.MsgQuantidadeInvalida);
            }

            RecuperarMaiorEMenorSalario(quantidadeDeFuncionariosInt);

            var continuarPrograma = Console.ReadLine();
            return continuarPrograma == MensagensGerais.ConstanteResultadoSim;
        }

        private static void RecuperarMaiorEMenorSalario(int quantidadeFuncionarios)
        {
            var menorSalario = new FuncionarioSalario();
            var maiorSalario = new FuncionarioSalario();

            for (var indice = 0; indice < quantidadeFuncionarios; indice++)
            {
                RecuperarFuncionariosESalarios(menorSalario, maiorSalario);
            }

            Console.WriteLine(MensagensGerais.FormatarMensagem(
                MensagensGerais.MsgMenorSalario, menorSalario.Nome, menorSalario.Salario.ToString()
            ));

            Console.WriteLine(MensagensGerais.FormatarMensagem(
                MensagensGerais.MsgMaiorSalario, maiorSalario.Nome, maiorSalario.Salario.ToString()
            ));
        }

        private static void RecuperarFuncionariosESalarios(FuncionarioSalario menorSalario, FuncionarioSalario maiorSalario)
        {
            Console.WriteLine(MensagensGerais.MsgInformeNomeESalario);
            var nomeSalario = Console.ReadLine().Split('/');
            var nome = nomeSalario[0];
            var salario = nomeSalario[1];
            var salarioFormatado = salario.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
            decimal salarioDecimal;

            while (!decimal.TryParse(salarioFormatado, out salarioDecimal))
            {
                Console.WriteLine(MensagensGerais.MsgSalarioInvalidoCalculo);
                salario = Console.ReadLine();
                salarioFormatado = salario.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
            }

            PreencherMenorSalario(menorSalario, nome, salarioDecimal);
            PreencherMaiorSalario(maiorSalario, nome, salarioDecimal);
        }

        private static void PreencherMenorSalario(FuncionarioSalario menorSalario, string novoFuncionario, decimal novoSalario)
        {
            if (string.IsNullOrEmpty(menorSalario.Nome) || novoSalario < menorSalario.Salario)
            {
                menorSalario.PreencherNome(novoFuncionario);
                menorSalario.PreencherSalario(novoSalario);
            }
        }

        private static void PreencherMaiorSalario(FuncionarioSalario maiorSalario, string novoFuncionario, decimal novoSalario)
        {
            if (string.IsNullOrEmpty(maiorSalario.Nome) || novoSalario > maiorSalario.Salario)
            {
                maiorSalario.PreencherNome(novoFuncionario);
                maiorSalario.PreencherSalario(novoSalario);
            }
        }
    }
}
