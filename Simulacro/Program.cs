using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
        //filtrarDigitosImparesC();
        /*string ora = "hola a todos ";
        int cant = ContarLetrasC(ora);
        Console.WriteLine("la oracion tiene " + cant + " palabras");*/
        
        /*int[] vec = { 1,2,3,4,5}; // Vector de ejemplo
        int a = 1; // Límite inferior del rango
        int b = 5; // Límite superior del rango

        int todosElementos = todosElementosEnRango(vec, a, b);
        Console.WriteLine("Hay " + todosElementos + " elementos dentro del rango.");*/
        int filas = 3; // Número de filas en la matriz
        int columnas = 5; // Número de columnas en la matriz

        int[,] matriz = GenerarMatrizB(filas, columnas);

        // Imprimir la matriz
        ImprimirMatriZ(matriz);

    }

    static void filtrarDigitosImparesA(int numero)
    {
        int resultado = 0;
        int potencia = 1;
        // Recorrer cada dígito del número
        while (numero != 0)
        {
            int digito = numero % 10; // saco el ultimo digito en una variable
            // Si el dígito es impar, agregarlo al resultado
            if (digito % 2 == 0) //si el el resto entre un numero dividido en 2 es 0, es par
            {
                resultado += digito * potencia; // hace que el numero se vaya colocando delante
                potencia *= 10;
            }
            // Dividir el número por 10 para pasar al siguiente dígito
                numero /= 10;
        }
                Console.WriteLine("El resultado es: " + resultado);
    }

    static void filtrarDigitosImparesB(int numero)
    {
        int resultado = 0;
        int potencia = 1;
        // Recorrer cada dígito del número
        while (numero != 0)
        {
            int digito = numero % 10; // saco el ultimo digito en una variable
            // Si el dígito es impar, agregarlo al resultado
            if (digito % 3 == 0) //si el el resto entre un numero dividido en 2 es 0, es par
            {
                resultado += digito * potencia; // hace que el numero se vaya colocando delante
                potencia *= 10;
            }
            // Dividir el número por 10 para pasar al siguiente dígito
                numero /= 10;
        }
                Console.WriteLine("El resultado es: " + resultado);
    }

    static void filtrarDigitosImparesC(int numero)
    {
        int resultado = 0;
        int potencia = 1;
        
        // Recorrer cada dígito del número
        while (numero != 0)
        {
            int digito = numero % 10; // Obtener el último dígito
            
            // Si el dígito es un número primo (2, 3, 5, 7), agregarlo al resultado
            if (digito == 2 || digito == 3 || digito == 5 || digito == 7)
            {
                resultado += digito * potencia; // Hace que el número se vaya colocando delante
                potencia *= 10;
            }
            
            // Dividir el número por 10 para pasar al siguiente dígito
            numero /= 10;
        }
        
        Console.WriteLine("El resultado es: " + resultado);
    }

    static int ContarVocales(string oracion)
    {
        int contadorVocales = 0;

        foreach (char caracter in oracion.ToLower()) // Convertimos todos los caracteres a minúsculas para comparar con las vocales
        {
            if (EsVocal(caracter)) // Verificamos si el caracter es una vocal
            {
                contadorVocales++;
            }
        }

        return contadorVocales;
    }

    static bool EsVocal(char caracter)
    {
        // Comprobamos si el caracter es una vocal (a, e, i, o, u)
        return caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u';
    }

    static int ContarLetrasB(string oracion)
    {
        int contador = 0; // Inicializamos un contador para contar las letras
        foreach (char caracter in oracion) // Iteramos sobre cada caracter en la oración
        {
            if (!char.IsWhiteSpace(caracter)) // Verificamos si el caracter no es un espacio en blanco
            {
                contador++; // Si el caracter no es un espacio en blanco, incrementamos el contador
            }
         }
            return contador;
    }

    static int ContarLetrasC(string oracion)
    {
        int contadorPalabras = 0;
        bool dentroPalabra = false;

        foreach (char caracter in oracion)
        {
            if (char.IsWhiteSpace(caracter)) // Verifica si el caracter es un espacio en blanco
            {
                dentroPalabra = false;
            }
            else if (!dentroPalabra)
            {
                contadorPalabras++;
                dentroPalabra = true;
            }
        }

        return contadorPalabras;
    }

    static bool todosElementosEnRango(int[] vector, int a, int b)
    {
        foreach (int elemento in vector) // Iteramos sobre cada elemento del vector
        {
            if (elemento < a || elemento > b) // Verificamos si el elemento está fuera del rango [a, b]
            {
                return false; // Si encontramos un elemento fuera del rango, devolvemos false
            }
        }
            return true; // Si todos los elementos están dentro del rango, devolvemos true al final del bucle
    }

    static int[,] GenerarMatrizPatron(int filas, int columnas)
    {
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[j, i] = i + 1;
            }
        }
            return matriz;
    }

    static int[,] GenerarMatrizPatronA(int filas, int columnas)
    {
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = i + j + 1;
            }
        }
        return matriz;
    }

    static void ImprimirMatriZ(int[,] matriz)
    {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);

        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                Console.Write(matriz[i, j].ToString().PadLeft(10)); // Ajustar el ancho del campo para que la salida sea alineada
            }
            Console.WriteLine(); // Salto de línea después de imprimir una fila completa
        }
    }

    static void ImprimirMatriz<T>(T[,] matriz)
        {
            for (int fila = 0; fila < matriz.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz.GetLength(1); columna++)
                {
                    Console.Write(matriz[fila, columna] + "\t");
                }
                Console.WriteLine();
            }
     }
    
    static int[,] GenerarMatrizB(int filas, int columnas)
    {
        int[,] matriz = new int[filas, columnas];
        for (int i = 0; i < filas; i++)
        {
            for (int j = 0; j < columnas; j++)
            {
                matriz[i, j] = (i + 1) * (j + 1);
            }
        }
        return matriz;
    }

  }
}