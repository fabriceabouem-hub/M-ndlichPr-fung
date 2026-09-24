using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Xml;

namespace MündlichPrüfung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = { 1, 2, 3, 4, 5, 6 };
            int gesuchteZahl = 5;

            int index = LineareSuche(zahlen, gesuchteZahl);

            if(index != -1)
            {
                Console.WriteLine($"Zahl {gesuchteZahl} am index {index} gefunden!");
            }
            else
            {
                Console.WriteLine($"Zahl nicht im Array enthalten. ");
            }

        }
        static int LineareSuche(int[] arr, int ziel)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == ziel)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
    