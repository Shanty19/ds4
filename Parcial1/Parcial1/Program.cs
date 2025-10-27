using System;

class NumeroaleatorioMatriz
{
    static void Main()
    {
        // esto crea un numero aleatorio el random
        
        Random aleatorio = new Random();

        // aqui pedimos un numero al usuario que sea par o mayor o igual a 6

        Console.WriteLine("Debe ingresar un número par mayor o igual a 6:");
        int N = int.Parse(Console.ReadLine());

        // aqui hacemos la comparacion si el número es válido o menor que 6
        // si no cumple con esta función , imprime que es inválido
        while (N < 6 || N % 2 != 0)
        {
            Console.WriteLine("El número que ingresó no es válido:"); // si el numero es inavalido, se muestra el mensaje hasta que le usuario escriba el número correcto
            N = int.Parse(Console.ReadLine());
        }

        // Creamos  la matriz
        int[,] matriz = new int[N, N];
        int suma = 0;  // variable que almacena la suma de los numeros aleatorios

        // Llenamos  la matriz con el patrón
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                // Si estamos en las 2 primeras o 2 últimas filas
                // y en las 2 primeras o 2 últimas columnas
                if ((i < 2 || i >= N - 2) && (j < 2 || j >= N - 2))
                {
                    matriz[i, j] = aleatorio.Next(101, 201);
                    suma += matriz[i, j];
                }

                // esta condición verifica si estamos en la diagonal correcta para posteriormente rellenarla.
                else if (i + j == N - 1)
                {
                    matriz[i, j] = aleatorio.Next(101, 201);
                    suma += matriz[i, j];
                }

                // esta condición verifica si estamos en el centro de la matriz
                else if ((i == N / 2 - 1 && j == N / 2) || (i == N / 2 && j == N / 2 - 1))
                {
                    matriz[i, j] = aleatorio.Next(101, 201);
                    suma += matriz[i, j];
                }
                else
                {
                    matriz[i, j] = 0;  // Si no estamos en una esquina, diagonal ni en el centro, ponemos cero en esa casilla.
                }
            }
        }

        // Mostramos  la matriz para imprimirla
        Console.WriteLine("\nMatriz:");
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(matriz[i, j] + "\t");  // usamos \t para que la matriz se vea ordenada
            }
            Console.WriteLine();
        }

        // Mostramos  la suma de los números aleatorios
        Console.WriteLine("\nSuma total de los números aleatorios: " + suma);
    }
}

