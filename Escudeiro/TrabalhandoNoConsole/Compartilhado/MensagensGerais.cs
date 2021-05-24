namespace TrabalhandoNoConsole.Compartilhado
{
    public static class MensagensGerais
    {
        #region Mensagens para o primeiro exercício

        public const string MsgInserirPrimeiroValorCalculo = "\nInsira o primeiro valor para os cálculos: ";
        public const string MsgInserirSegundoValorCalculo = "\nInsira o segundo valor para os cálculos: ";
        public const string MsgNumeroInvalidoCalculo = "\nNúmero inválido, escreva em qualquer formato decimal válido.";
        public const string MsgValorParOuImpar = "{0}{1} - {2}";
        public const string MsgResultadoValoresCalculo = "{0}Resultado dos valores {1} é igual a {2}";

        public const string ConstantePar = "Par";
        public const string ConstanteImpar = "Ímpar";
        public const string ConstanteSomados = "somados";
        public const string ConstanteSubtraidos = "subtraídos";
        public const string ConstanteDivididos = "divididos";
        public const string ConstanteMultiplicados = "multiplicados";
        public const string ConstanteResultadoSim = "s";
        public const string ConstantePonto = ".";
        public const string ConstanteVirgula = ",";
        public const string EspacoLinha = "\n";

        #endregion

        #region Mensagens para o segundo exercício

        public const string MsgInformandoComoFuncionaALeituraDeSalarios = "\nSerá requisitado uma quantidade de funcionários e após " +
            "isso serão solicitados n vezes o nome e salário.";
        public const string MsgSolicitarQuantidadeDeFuncionarios = "Informe a quantidade de funcionários que deseja utilizar: ";
        public const string MsgInformeNomeESalario = "\nInfome o nome e salário do funcionário, separados por uma barra(/) ";
        public const string MsgQuantidadeInvalida = "\nQuantidade de funcionárias inválida, preencha com um valor inteiro maior que zero";
        public const string MsgSalarioInvalidoCalculo = "\nSalário inválido, escreva em qualquer formato decimal válido.";
        public const string MsgMenorSalario = "{0} possuí o menor salário, com o valor de {1}.";
        public const string MsgMaiorSalario = "{0} possuí o maior salário, com o valor de {1}.";

        #endregion

        #region MensagensGerais

        public const string MsgExecutarOutroExercicio = "\nDeseja executar algum outro exercício? (s/n)";
        public const string MsgResultadoCabecalho = "\n################ RESULTADO ################";


        public static string FormatarMensagem(string valor1, string valor2)
        {
            return string.Format(valor1, valor2);
        }

        public static string FormatarMensagem(string valor1, string valor2, string valor3)
        {
            return string.Format(valor1, valor2, valor3);
        }

        public static string FormatarMensagem(string valor1, string valor2, string valor3, string valor4)
        {
            return string.Format(valor1, valor2, valor3, valor4);
        }

        #endregion
    }
}
