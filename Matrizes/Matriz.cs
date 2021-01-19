using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.Matrizes
{
    class Matriz
    {
        static void Main(string[] args)
        {
           
            // matrizes
            int[,] matriz = new int[3,5];

            matriz[0, 0] = 10; matriz[0, 1] = 50; matriz[0, 2] = 0; matriz[0, 3] = 10; matriz[0, 0] = 20;
            matriz[1, 0] = 70; matriz[1, 1] = 60; matriz[1, 2] = 55; matriz[1, 3] = 6; matriz[1, 0] = 2;
            matriz[2, 0] = 17; matriz[2, 1] = 16; matriz[2, 2] = 25; matriz[2, 3] = 65; matriz[2, 0] = 2;

            // outra forma de inicializar

            int[,] matriz2 = new int[2, 2] { { 15,25 }, { 30,40 } };

            
        }
    }
}
