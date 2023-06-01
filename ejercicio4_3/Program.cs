using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número de cuadrados o rectángulos que desea dibujar: ");
        int numFormas = int.Parse(Console.ReadLine());

        for (int i = 0; i < numFormas; i++)
        {
            Console.Write("Ingrese el ancho: ");
            int ancho = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el alto: ");
            int alto = int.Parse(Console.ReadLine());

            Console.Write("Ingrese 1 para relleno o 0 para no relleno: ");
            int relleno = int.Parse(Console.ReadLine());

            if (ancho == alto)
            {
                DibujarCuadrado(ancho, relleno==1);
            }
            else
            {
                DibujarRectangulo(ancho, alto, relleno==1);
            }

            Console.WriteLine();
        }
    }

    static void DibujarCuadrado(int lado, bool relleno)
    {
        if (relleno)
        {
            for (int i = 0; i < lado; i++)
            {
                Console.WriteLine(new string('*', lado));
            }
        }
        else
        {
            Console.WriteLine(new string('*', lado));

            for (int i = 0; i < lado - 2; i++)
            {
                Console.WriteLine('*' + new string(' ', lado - 2) + '*');
            }

            Console.WriteLine(new string('*', lado));
        }
    }

    static void DibujarRectangulo(int ancho, int alto, bool relleno)
    {
        for (int i = 0; i < alto; i++)
        {
            if (i == 0 || i == alto - 1 || !relleno)
            {
                Console.WriteLine(new string('*', ancho));
            }
            else
            {
                Console.WriteLine('*' + new string(' ', ancho - 2) + '*');
            }
        }
    }
}