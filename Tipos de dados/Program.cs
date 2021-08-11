using System;

namespace Tipos_de_dados
{
    class Program
    {
        class TiposdeDados
        {
            enum Notas
            {
                Minimo = 10, Media = 20, Maxima = 30
            }

            struct Pessoa
            {
                public string nome;
                public int idade;
                public double altura;
            }
            static void Main(string[] args)
            {
                #region Numericas Integrais
                //integral assinado
                sbyte num1 = 10; //8bits, de -128 a 127
                short num2 = 20; //16bits, de -32.768 a 32.767
                int num3 = 30; //32bits, de -2.147.483.648 a 2.147.483.647
                long num4 = 40L; //64bits, de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807

                //integral sem sinal
                byte num5 = 10; //8bits, de 0 a 255
                ushort num6 = 20;//16bits, de 0 a 65.535
                uint num7 = 30; //32bits, de 0 a 4.294.967.295
                ulong num8 = 40L; //64bits, de 0 a 18.446.744.073.709.551.615
                #endregion

                #region Numeros Reais
                float real1 = 100.75f; //32bits, de 1,5 x 10-45 a 3.4 x 1038, precisão de 7 dígitos.
                double real2 = 12500.45; //64bits, de 5,0 x 10-324 a 1,7 x 10308, precisao de 15 digitos.
                decimal real3 = 752538.475m; //128bits, intervalo de pelo menos -7,9 x 10-28 a 7,9 x 1028, precisao de 28 dígitos.
                #endregion

                #region Caractere
                char letra = 'C';
                #endregion

                #region Boolean
                bool verificar = true;
                #endregion

                #region String
                string texto = "Pode-se colocar qualquer caractere";
                #endregion

                #region Var
                var valor = "texto";
                var valor2 = "2";
                var valor3 = true;
                #endregion

                #region Object
                object obj = true;
                obj = 2;
                obj = "texto";
                #endregion

                #region Constantes
                const double pi = 3.1415;//Não pode ser alterado;
                #endregion

                #region Enum
                Notas notasAlunos = Notas.Media;
                #endregion

                #region Struct
                Pessoa p1 = new Pessoa()
                {
                    nome = "Kleber",
                    idade = 19,
                    altura = 1.81
                };
                #endregion
            }
        }
    }
}