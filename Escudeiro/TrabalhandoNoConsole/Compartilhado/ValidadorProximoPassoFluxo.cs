using System;

namespace TrabalhandoNoConsole.Compartilhado
{
    public static class ValidadorProximoPassoFluxo
    {
        public static bool ValidarSeUsuarioContinuaraPrograma()
        {
            Console.WriteLine(MensagensGerais.MsgExecutarOutroExercicio);
            var continuarPrograma = Console.ReadLine();
            return continuarPrograma == MensagensGerais.ConstanteResultadoSim;
        }
    }
}
