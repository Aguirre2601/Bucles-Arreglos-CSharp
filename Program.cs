using System;

namespace Bucles_Arreglos
{
    class Program
    {
        public static void Main(string[] args)
        {
            Variables.C1 = 0;
            Variables.C2 = 0;
            Variables.C3 = 0;
            Variables.C4 = 0;
            Variables.C5 = 0;
            Variables.C6 = 0;
            Variables.numero = new Random();
            Variables.Array = new int[5, 5];
            Jugada.Cargar();
            Tiro(Variables.Array);
            Console.Write("1 = {0} veces\n", Variables.C1);
            Console.Write("2 = {0} veces\n", Variables.C2);
            Console.Write("3 = {0} veces\n", Variables.C3);
            Console.Write("4 = {0} veces\n", Variables.C4);
            Console.Write("5 = {0} veces\n", Variables.C5);
            Console.Write("6 = {0} veces\n", Variables.C6);
            Console.Write("\n Presione cualquier tecla para SALIR");
            Console.ReadKey();
        }
        public static void Tiro(int[,] Array)
        {
            for (int f = 0; f < 5; f++)
            {
                Console.Write("Tiro " + (f + 1) + ": ");
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("  " + Array[f, c]);
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }
}