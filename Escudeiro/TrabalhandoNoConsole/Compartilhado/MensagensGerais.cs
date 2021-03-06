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

        #region Mensagens para o quarto exercício

        public const string MsgNotaInvalida = "\nNota inválida, escreva em qualquer formato decimal válido.";
        public const string MsgNomeAluno = "\nInforme o nome do aluno {0}: ";
        public const string MsgNotaAluno = "Informe a nota {0} do aluno {1}:";
        public const string MsgNotasAcimaDe7 = "Alunos com média acima de 7: ";
        public const string MsgAlunoMedia = "{0} - Média: {1}";
        public const string MsgFinalizarNotas = "\nA seguir serão pedidas as notas, digite /fimN para finalizar o preenchimento das notas " +
            "ou /fimA para finalizar o preenchimento dos alunos: ";

        #endregion

        #region Mensagens para o quinto exercício

        public const string MsgValorBhaskara = "Informe o valor {0}:";
        public const string MsgValorInvalido = "\nValor inválido, escreva em qualquer formato decimal válido.";
        public const string MsgResultadoR1 = "\nR1 = {0}";
        public const string MsgResultadoR2 = "\nR2 = {0}";

        #endregion

        #region MensagensGerais

        public const string MsgExecutarOutroExercicio = "\nDeseja executar algum outro exercício? (s/n)";
        public const string MsgResultadoCabecalho = "\n################ RESULTADO ################";
        public const string MsgExercicios = "\n################ EXERCICIOS ################";


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
