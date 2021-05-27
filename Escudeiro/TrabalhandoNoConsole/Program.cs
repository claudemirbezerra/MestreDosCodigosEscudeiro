using System;
using TrabalhandoNoConsole.Compartilhado;
using TrabalhandoNoConsole.Funcionalidades;

namespace TrabalhandoNoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            SelecionarExercicio();
        }

        private static void SelecionarExercicio(bool mostrarOpcoes = true)
        {
            if (mostrarOpcoes)
            {
                Console.WriteLine(MensagensGerais.MsgExercicios);

                var textoOpcoes = "1 - Exercício 1 - Cálculos \n";
                textoOpcoes += "2 - Exercício 2 - Salários \n";
                textoOpcoes += "3 - Exercício 3 - Multiplos de 3 \n";
                textoOpcoes += "4 - Exercício 4 - Notas \n";
                textoOpcoes += "5 - Exercício 5 - Formula Bhakara \n";
                textoOpcoes += "6 - Exercício 6 - Diferença Ref e Out \n";
                textoOpcoes += "7 - Exercício 7 - Soma pares \n";
                textoOpcoes += "8 - Exercício 8 - Ordenação \n";
                textoOpcoes += "9 - Exercício 9 - LINQ \n";
                textoOpcoes += "0 - SAIR \n";
                textoOpcoes += "Entre com uma da opções acima(apenas o número): ";

                Console.WriteLine(textoOpcoes);
            }

            var valorOpcao = Console.ReadLine();
            var continuarPrograma = false;

            switch (valorOpcao)
            {
                case "1":
                    continuarPrograma = Exercicio1Calculos.SolicitarPreenchementoDeValoresParaOUsuario();
                    break;
                case "2":
                    continuarPrograma = Exercicio2Salarios.SolicitarPreenchementoDeValoresParaOUsuario();
                    break;
                case "3":
                    continuarPrograma = Exercicio3MultiplosDe3.ImprimirMultiplosDe3Do1Ao100();
                    break;
                case "4":
                    continuarPrograma = Exercicio4AlunosAprovados.SolicitarPreenchementoDeValoresParaOUsuario();
                    break;
                case "0":
                    continuarPrograma = false;
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, entre com um número válido: ");
                    SelecionarExercicio(false);
                    break;
            }

            if (continuarPrograma)
            {
                Console.WriteLine("\n");
                SelecionarExercicio();
            }
        }

        private static void SelecionarOpcoesDoExercicio5()
        {
        }

        private static void SelecionarOpcoesDoExercicio6()
        {
        }

        private static void SelecionarOpcoesDoExercicio7()
        {
        }

        private static void SelecionarOpcoesDoExercicio8()
        {
        }

        private static void SelecionarOpcoesDoExercicio9()
        {
        }
    }
}
