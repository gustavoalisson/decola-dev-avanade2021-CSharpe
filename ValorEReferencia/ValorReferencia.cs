using System;
using System.Collections.Generic;
using System.Text;

namespace AprendendoCSharpe.ValorEReferencia
{
    class ValorReferencia
    {
        //Passando um valor por referência
        static void Main()
        {
            int valor = 15;
            DobraValor(ref valor);
            Console.WriteLine(valor);

        }

        static void DobraValor(ref int x)
        {
            x *= 2;
        }
    }

}
