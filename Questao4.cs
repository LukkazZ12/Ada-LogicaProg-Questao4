using System;

namespace Questao4
{
    internal class Questao04
    {
        static void Main(string[] args)
        {
            public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
                => Convert.ToInt32(Math.Floor(Decimal.Divide(totalNegociado * porcentagem, Decimal.Subtract(1, porcentagem))));
        }
    }
}
