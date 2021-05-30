using System;
using System.Collections.Generic;
using TrabalhandoNoConsole.Compartilhado;

namespace TrabalhandoNoConsole.Funcionalidades
{
    public static class Exercicio5Bhaskara
    {
        public static bool SolicitarPreenchementoDeValoresParaOUsuario()
        {
            var valores = SolicitarPreenchimentoDosValores();

            var mensagensResultado = CalcularResultados(valores);
            ImpressorDeResultado.Imprimir(mensagensResultado);

            return ValidadorProximoPassoFluxo.ValidarSeUsuarioContinuaraPrograma();
        }

        private static List<double> SolicitarPreenchimentoDosValores()
        {
            var valores = new List<double>();

            for (int i = 1; i <= 3; i++)
            {
                var letraValor = RecuperarLetraValor(i);
                var mensagemRequisicao = MensagensGerais.FormatarMensagem(MensagensGerais.MsgValorBhaskara, letraValor);
                var valor = TratadorDeEntradaDouble.LerValorEmFormatoDouble(mensagemRequisicao, MensagensGerais.MsgValorInvalido);

                valores.Add(valor);
            }

            return valores;
        }

        private static List<string> CalcularResultados(List<double> valores)
        {
            var mensagensResultado = new List<string>();
            var a = valores[0];
            var b = valores[1];
            var c = valores[2];

            var delta1 = (b*b);
            var delta2 = (4 * a * c);

            var delta = (delta1 - delta2);
            var raiz = Math.Sqrt(delta);

            var r1 = (-b  + raiz) / (2 * a);
            var r2 = (-b - raiz) / (2 * a);

            mensagensResultado.Add(MensagensGerais.FormatarMensagem(MensagensGerais.MsgResultadoR1, r1.ToString()));
            mensagensResultado.Add(MensagensGerais.FormatarMensagem(MensagensGerais.MsgResultadoR2, r2.ToString()));

            return mensagensResultado;
        }

        private static string RecuperarLetraValor(int indice)
        {
            var letraValor = string.Empty;

            switch (indice) {
                case 1:
                    letraValor = "A";
                    break;
                case 2:
                    letraValor = "B";
                    break;
                case 3:
                    letraValor = "C";
                    break;
            }

            return letraValor;
        }

    }
}
