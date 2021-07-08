using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Params
{
    internal class Display
    {
        internal static void Show(params int[] val)
        {
            foreach(int x in val)
            {
                Console.Write(x + "\t");
            }
        }
    }
}
