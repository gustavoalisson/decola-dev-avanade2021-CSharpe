using System;

namespace AprendendoCSharpe.Loops
{
    class LoopFor
    {
        static void Main()
        {
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
        }
    }
}
