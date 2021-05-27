using System;
using TrabalhandoNoConsole.Compartilhado;

namespace TrabalhandoNoConsole.Funcionalidades
{
    public static class Exercicio3MultiplosDe3
    {
        public static bool ImprimirMultiplosDe3Do1Ao100()
        {
            var contador = 1;
            var multiploDe3 = 0;
            Console.WriteLine(MensagensGerais.MsgResultadoCabecalho);

            while (multiploDe3 <= 100)
            {
                Console.WriteLine(multiploDe3);
                multiploDe3 = contador * 3;
                contador++;
            }

            return ValidadorProximoPassoFluxo.ValidarSeUsuarioContinuaraPrograma();
        }
    }
}
