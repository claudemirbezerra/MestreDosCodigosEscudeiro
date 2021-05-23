using System;
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
                var textoOpcoes = "1 - Exercício 1 - Cálculos \n";
                textoOpcoes += "2 - Exercício 2 - Salários \n";
                textoOpcoes += "3 - Exercício 3 - Multiplos de 3 \n";
                textoOpcoes += "4 - Exercício 4 - Notas \n";
                textoOpcoes += "5 - Exercício 5 - Formula Bhakara \n";
                textoOpcoes += "6 - Exercício 6 - Diferença Ref e Out \n";
                textoOpcoes += "7 - Exercício 7 - Soma pares \n";
                textoOpcoes += "8 - Exercício 8 - Ordenação \n";
                textoOpcoes += "9 - Exercício 9 - LINQ \n";
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
                default:
                    Console.WriteLine("\nOpção inválida, entre com um número válido: ");
                    SelecionarExercicio(false);
                    break;
            }

            if (continuarPrograma)
            {
                Console.WriteLine("\n\n");
                SelecionarExercicio();
            }
        }

        private static void SelecionarOpcoesDoExercicio2()
        {
        }

        private static void SelecionarOpcoesDoExercicio3()
        {
        }

        private static void SelecionarOpcoesDoExercicio4()
        {
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
