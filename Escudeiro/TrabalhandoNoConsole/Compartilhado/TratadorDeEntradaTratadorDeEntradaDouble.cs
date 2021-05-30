using System;

namespace TrabalhandoNoConsole.Compartilhado
{
    public static class TratadorDeEntradaDouble
    {
        public static double LerValorEmFormatoDouble(string mensagemRequisicao, string mensagemErro)
        {
            Console.WriteLine(mensagemRequisicao);
            var valor = Console.ReadLine();
            var valorFormatado = valor.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
            double valorCorreto;

            while (!double.TryParse(valorFormatado, out valorCorreto))
            {
                Console.WriteLine(mensagemErro);
                valor = Console.ReadLine();
                valorFormatado = valor.Replace(MensagensGerais.ConstantePonto, MensagensGerais.ConstanteVirgula);
            }

            return valorCorreto;
        }

    }
}
