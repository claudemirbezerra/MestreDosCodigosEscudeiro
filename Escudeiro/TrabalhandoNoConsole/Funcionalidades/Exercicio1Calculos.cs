using System;
using TrabalhandoNoConsole.Compartilhado;

namespace TrabalhandoNoConsole.Funcionalidades
{
    public static class Exercicio1Calculos
    {
        public static bool SolicitarPreenchementoDeValoresParaOUsuario()
        {
            var primeiroValor = ReceberValorParaCalculo(MensagensGerais.MsgInserirPrimeiroValorCalculo);
            var segundoValor = ReceberValorParaCalculo(MensagensGerais.MsgInserirSegundoValorCalculo);

            RealizarCalculos(primeiroValor, segundoValor);

            Console.WriteLine(MensagensGerais.MsgExecutarOutroExercicio);

            var continuarPrograma = Console.ReadLine();
            return continuarPrograma == MensagensGerais.ConstanteResultadoSim;
        }

        private static decimal ReceberValorParaCalculo(string mensagem)
        {
            Console.WriteLine(mensagem);
            var valorString = Console.ReadLine();
            var valorFormatado = valorString.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
            decimal valorDecimal;

            if (decimal.TryParse(valorFormatado, out valorDecimal))
                return valorDecimal;

            Console.WriteLine(MensagensGerais.MsgNumeroInvalidoCalculo);
            valorDecimal = ReceberValorParaCalculo(mensagem);
            return valorDecimal;
        }

        private static string RetornarSeValorImparOuPar(decimal valor)
        {
            var resultado = MensagensGerais.ConstantePar;

            if ((valor % 2) != 0)
                resultado = MensagensGerais.ConstanteImpar;

            return resultado;
        }

        private static void RealizarCalculos(decimal primeiroValor, decimal segundoValor)
        {
            var valorSomado = primeiroValor + segundoValor;
            var valorSubtraido = primeiroValor - segundoValor;
            var valorDividido = primeiroValor / segundoValor;
            var valorMultiplicado = primeiroValor * segundoValor;

            var resultado = RetornarResultadoMensagem(valorSomado, MensagensGerais.ConstanteSomados);
            resultado += RetornarResultadoMensagem(valorSubtraido, MensagensGerais.ConstanteSubtraidos);
            resultado += RetornarResultadoMensagem(valorDividido, MensagensGerais.ConstanteDivididos);
            resultado += RetornarResultadoMensagem(valorMultiplicado, MensagensGerais.ConstanteMultiplicados);

            resultado +=
                MensagensGerais.FormatarMensagem(
                    MensagensGerais.MsgValorParOuImpar, MensagensGerais.EspacoLinha, primeiroValor.ToString(), RetornarSeValorImparOuPar(primeiroValor)
                );
            resultado +=
                MensagensGerais.FormatarMensagem(
                    MensagensGerais.MsgValorParOuImpar, MensagensGerais.EspacoLinha, segundoValor.ToString(), RetornarSeValorImparOuPar(segundoValor)
                );

            Console.WriteLine(resultado);
        }

        private static string RetornarResultadoMensagem(decimal valor, string complementoMensagem)
        {
            var mensagem = MensagensGerais.FormatarMensagem(
                    MensagensGerais.MsgResultadoValoresCalculo, MensagensGerais.EspacoLinha, complementoMensagem, valor.ToString()
                );
            return mensagem;
        }
    }
}
