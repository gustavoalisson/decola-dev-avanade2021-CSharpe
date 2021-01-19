using System;


namespace AprendendoCSharpe.Enum
{
    class Enumerador
    {
        //Usando valores pré definidos
        enum DiasSemana {Domingo, Segunda, Terça, Quarta, Quinta, Sexta};

        static void Main()
        {
            DiasSemana ds = DiasSemana.Domingo;
            Console.WriteLine(ds);

            // Pegando o Enum pelo indice
            // uso do cast
            DiasSemana diaAtual = (DiasSemana) 1;
            Console.WriteLine(diaAtual);

            //Outra forma
            int ds2 = (int)DiasSemana.Sexta;
            Console.WriteLine(ds2);

        }
    }
}
