using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Tipos_de_array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region Vetor unidimensional
            /*
            int numero = 0;

            int[] numeros = new int[5];//Declarando um array

            numeros[0] = 10;//atribuir valor ao índice 0 do array
            numeros[1] = 20;//atribuir valor ao índice 1 do array
            numeros[2] = 30;//atribuir valor ao índice 2 do array
            numeros[3] = 40;//atribuir valor ao índice 3 do array
            numeros[4] = 50;//atribuir valor ao índice 4 do array


            string[] nomes = new string[3];
            nomes[0] = "Kleber";
            nomes[1] = "Luccas";
            nomes[2] = "Kleber Luccas";

            string[] nomes2 = {"kleber", "luccas", "kleberluccas"};//vetor inline
            */
            #endregion

            #region Vetor Bidimensional
            /*
            int[,] numeros = new int[2,3];//2 linhas e 3 colunas.
            numeros[0, 0] = 10;
            numeros[0, 1] = 20;
            numeros[0, 2] = 30;

            numeros[1, 0] = 10;
            numeros[1, 1] = 20;
            numeros[1, 2] = 30;
            
            Console.Write("[" + numeros[0,0] + "]");
            Console.ReadKey();
            
            string[,] nomes =
            {
                {"Nome1", "Nome2", "Nome3"},
                {"Nome1", "Nome2", "Nome3"}
            }
            */
            #endregion

            #region Multiplicação vetorial

            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[3, 2];
            int[,] resultado = new int[2, 2];
            
            Console.WriteLine("Preencher a primeira matriz");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int Coluna = 0; Coluna < 3; Coluna++)
                {
                    Console.Write("#1. Posição [" +linha + " - "+ Coluna + "]");
                    matriz1[linha, Coluna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Preencher a segunda matriz");
            
            for (int linha = 0; linha < 3; linha++)
            {
                for (int Coluna = 0; Coluna < 2; Coluna++)
                {
                    Console.Write("#2. Posição [" +linha + " - "+ Coluna + "]");
                    matriz2[linha, Coluna] = int.Parse(Console.ReadLine());
                }
            }
            
            Console.WriteLine("\nResultado da matriz1 x matriz2");
            resultado[0, 0] = (matriz1[0, 0]*matriz2[0, 0]) + (matriz1[0, 1]*matriz2[1, 0]) + (matriz1[0, 2]*matriz2[2, 0]);
            resultado[1, 0] = (matriz1[1, 0]*matriz2[0, 0]) + (matriz1[1, 1]*matriz2[1, 0]) + (matriz1[1, 2]*matriz2[2, 0]);
            resultado[0, 1] = (matriz1[0, 1]*matriz2[0, 1]) + (matriz1[0, 1]*matriz2[1, 1]) + (matriz1[0, 2]*matriz2[2, 1]);
            resultado[1, 1] = (matriz1[1, 0]*matriz2[0, 1]) + (matriz1[1, 1]*matriz2[1, 1]) + (matriz1[1, 2]*matriz2[2, 1]);
            
            Console.WriteLine("[" + resultado[0, 0] + "][" + resultado[0, 1] + "]");
            Console.WriteLine("[" + resultado[1, 0] + "][" + resultado[1, 1] + "]");

            Console.ReadKey();

            #endregion

        }
    }
}