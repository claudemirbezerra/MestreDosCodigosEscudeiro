using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhandoNoConsole.Funcionalidades
{
    public static class Exercicio1Calculos
    {
        public static Boolean SolicitarPreenchementoDeValoresParaOUsuario()
        {
            var primeiroValor = ReceberValorParaCalculo("\nInsira o primeiro valor para os cálculos(para decimais utiliza a vírgula): ");
            var segundoValor = ReceberValorParaCalculo("\nInsira o segundo valor para os cálculos(para decimais utiliza a vírgula): ");

            RealizarCalculos(primeiroValor, segundoValor);

            Console.WriteLine("Deseja executar algum outro exercício? (s/n)");
            var continuarPrograma = Console.ReadLine();
            var continuarProgramaBoolean = continuarPrograma == "s";

            return continuarProgramaBoolean;
        }

        private static void RealizarCalculos(decimal primeiroValor, decimal segundoValor)
        {
            var valorSomado = primeiroValor + segundoValor;
            var valorSubtraido = primeiroValor - segundoValor;
            var valorDividido = primeiroValor / segundoValor;
            var valorMultiplicado = primeiroValor * segundoValor;

            var resultado = RetornarResultadoMensagem(valorSomado, "somados");
            resultado += RetornarResultadoMensagem(valorSubtraido, "subtraídos");
            resultado += RetornarResultadoMensagem(valorDividido, "divididos");
            resultado += RetornarResultadoMensagem(valorMultiplicado, "multiplicados");

            resultado += "\n" + primeiroValor + " - " + RetornarSeValorImparOuPar(primeiroValor);
            resultado += "\n" + segundoValor + " - " + RetornarSeValorImparOuPar(segundoValor);

            Console.WriteLine(resultado);
        }

        private static string RetornarSeValorImparOuPar(decimal valor)
        {
            var resultado = "Par";

            if ((valor % 2) != 0)
            {
                resultado = "Ímpar";
            }

            return resultado;
        }

        private static string RetornarResultadoMensagem(decimal valor, string complementoMensagem)
        {
            var mensagem = "\nResultado dos valores " + complementoMensagem + " é igual a " + valor;
            return mensagem;
        }

        private static decimal ReceberValorParaCalculo(string mensagem)
        {
            Console.WriteLine(mensagem);
            var valorString = Console.ReadLine();
            decimal valorDecimal;

            if (decimal.TryParse(valorString, out valorDecimal))
            {
                return valorDecimal;
            }

            Console.WriteLine("\nNúmero inválido, escreva em qualquer formato decimal válido.");
            valorDecimal = ReceberValorParaCalculo(mensagem);
            return valorDecimal;
        }
    }
}
