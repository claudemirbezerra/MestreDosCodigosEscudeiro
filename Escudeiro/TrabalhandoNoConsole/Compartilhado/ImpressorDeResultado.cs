using System;
using System.Collections.Generic;

namespace TrabalhandoNoConsole.Compartilhado
{
    public static class ImpressorDeResultado
    {
        public static void Imprimir(List<string> mensagens)
        {
            Console.WriteLine(MensagensGerais.MsgResultadoCabecalho);

            mensagens.ForEach(mensagem =>
            {
                Console.WriteLine(mensagem);
            });            
        }
    }
}
