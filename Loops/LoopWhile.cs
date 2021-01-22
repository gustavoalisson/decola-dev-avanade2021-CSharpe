using System;


namespace AprendendoCSharpe.Loops
{
    class LoopWhile
    {
        static void Main()
        {
            int[] num = new int[10];
            int i = num.Length - 1;

            while(i > 0){
                num[i] = i;
                Console.WriteLine($"Numero: {num[i]}");
                i--;
            }
        }
    }
}
