using System;

namespace Conversões
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conversão implícita
            /*
            byte num1 = 100;
            ushort num2;

            float num3 = 1250.45f;
            double num4;

            //a linguagem aceta pois não há perda de dados
            num2 = num1;
            num4 = num3;
            num3 = num2;
            */
            #endregion

            #region Conversão explícita
            /*
            byte num1;
            ushort num2 = 500;

            num1 = (byte)num2;//houve perda de dados pois o valor byte não cabe 500

            float num3 = 2500.786f;
            int num4 = (int)num3;//houve perda de dados pois int não aceita decimal.

            char letra = (char)97; //ele entende como código da letra em UTF-
            */
            #endregion

            #region Parse
            string txtnumero = "1985";

            int numero = int.Parse(txtnumero);
            #endregion

            #region Convert
            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);//aparece 0

            int num2 = Convert.ToInt32('C');//aparece o codigo decimal da letra
            #endregion
        }
    }
}
