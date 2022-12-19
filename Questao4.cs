using System;

namespace Questao4
{
    internal class Questao4
    {
        static void Main(string[] args)
        {
            public static int funcaoRetornaQuantitadePOV(decimal porcentagem, int totalNegociado)
                => Convert.ToInt32(Math.Floor(Decimal.Divide(totalNegociado * porcentagem, Decimal.Subtract(1, porcentagem))));
        }
    }
}
