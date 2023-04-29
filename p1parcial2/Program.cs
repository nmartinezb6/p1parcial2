

using System;

class BatallaNaval
{
    static void Main()
    {
        int[,] tablero = new int[10, 10];
        // Inicializamos el tablero con ceros para indicar que no hay barcos
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                tablero[i, j] = 0;
            }
        }

        // Colocamos los barcos en el tablero de forma aleatoria
        Random rnd = new Random();
        int barcosColocados = 0;
        while (barcosColocados < 5)
        {
            int fila = rnd.Next(10);
            int columna = rnd.Next(10);
            if (tablero[fila, columna] == 0)
            {
                // Colocamos un barco en la casilla (fila, columna)
                tablero[fila, columna] = 1;
                barcosColocados++;
            }
        }

        // Comenzamos el juego
        int intentos = 0;
        int barcosHundidos = 0;
        while (barcosHundidos < 5)
        {
            Console.WriteLine("Intento número " + (intentos + 1));
            Console.Write("Ingrese la fila: ");
            int fila = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la columna: ");
            int columna = int.Parse(Console.ReadLine());
            if (tablero[fila, columna] == 1)
            {
                Console.WriteLine("¡Barco hundido!");
                tablero[fila, columna] = 2; // Marcamos la casilla como hundida
                barcosHundidos++;
            }
            else if (tablero[fila, columna] == 2)
            {
                Console.WriteLine("Ya has disparado en esta casilla");
            }
            else
            {
                Console.WriteLine("Agua");
            }
            intentos++;
        }

        Console.WriteLine("¡Has ganado en " + intentos + " intentos!");
    }
}
