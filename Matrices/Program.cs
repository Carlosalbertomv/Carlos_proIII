using System;

namespace programa
{
    class FuncionesUtiles
    {
        static void Main(string[] args)
        {
            /*int[,] numero = LlenarMatrizSerpiente(4, 4); 
            ImprimirMatriz(numero);*/
            /*int[,] numeros = new int[5 , 7];
            int numero = 1;
            
            for (int columnas = 0; columnas < numeros.GetLength(1); columnas++)
            {
                numeros[1, columnas] = 3;
                //numeros = numeros + 2;
            }

            for (int fila  = 0; fila < numeros.GetLength(0); fila++)
            {
                numeros[fila, 1] = 10;
            }

            int menor = numMenor(numeros.GetLength(0), numeros.GetLength(1));

            for (int i = 0; i < menor; i++)
            {
                numeros[i, i] = 99;
            }

            
            /*for (int fila = 0; fila < numeros.GetLength(0); fila++)
            {
                numeros [fila , 1] = 10;
            }

            for (int fila = 0; fila < numeros.GetLength(0); fila++)
            {
                numeros [fila , 1] = 10;
            }
            ImprimirMatriz(numeros);*/

            int [,] mat = LlenarMatrizC(4,4);
            ImprimirMatriz(mat);
        }

        /////////////NUMEROS////////////////////
        ///
        

        static int[,] LlenarMatrizSerpienteB(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas

            int valor = 1;
            for (int fila = 0; fila < filas; fila++)
            {
                // Determinar la dirección de llenado de la fila (izquierda a derecha o derecha a izquierda)
                bool derecha = fila % 2 == 0;

                // Llenar la fila en la dirección determinada
                if (derecha)
                {
                    for (int columna = 0; columna < columnas; columna++)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
                else
                {
                    for (int columna = columnas - 1; columna >= 0; columna--)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
            }

            return matriz;
        }

        static int[,] LlenarMatrizC(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas
            int contador = 1;

            for (int f = filas -1 ; f >=0; f--)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = contador;
                    contador = contador + 1;
                    
                     // Llenar la matriz con números del 1 al número de columnas
                }
            }

            return matriz;
        }

        static int[,] LlenarMatrizB(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas
            int contador = 1;

            for (int c  = columnas -1 ; c >=0; c--)
            {
                for (int f = 0; f < filas; f++)
                {
                    matriz[f, c] = contador;
                    contador = contador + 1;
                    
                     // Llenar la matriz con números del 1 al número de columnas
                }
            }

            return matriz;
        }

        static int[,] LlenarMatrizA(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas
            int contador = 1;

            for (int f = filas -1 ; f >=0; f--)
            {
                for (int c = 0; c < columnas; c++)
                {
                    matriz[f, c] = contador;
                    contador = contador + 1;
                    
                     // Llenar la matriz con números del 1 al número de columnas
                }
            }

            return matriz;
        }


        static void EvaluarNota(int nota)
        {
            if (nota > 50)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }


        static int mayor(int num1, int num2) // sacar el mayor de dos numeros
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static int numMenor(int num1, int num2) // sacar el mayor de dos numeros
        {
            if (num1 < num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        static int suma_elementos(int elemento1, int elemento2) //sumar dos numeros
        {
            int suma = elemento1 + elemento2;
            return suma;

        }

        static void rotarNumero() // poner el ultimo numero al inicio
        {
            Console.Write("Ingrese un número: ");
            string input = Console.ReadLine();

            // Rotar los dígitos
            char lastDigit = input[input.Length - 1];
            string rotatedNumber = lastDigit + input.Substring(0, input.Length - 1);

            Console.WriteLine("Número rotado: " + rotatedNumber);
        }

        static int contarDigitos(int numero) // devuelve cantidad de digitos de un numero
        {
            return numero.ToString().Length;
        }

        static bool esPar(int numero) // devuelve True si es par
        {
            if ((numero % 2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool esPrimo(int numero) // devuelve true si es primo
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void FiltrarDigitosImpares(int numero) //pide un numero y revuelve el numero pero solo los digitos impares
        {
            int resultado = 0;
            int potencia = 1;

            // Recorrer cada dígito del número
            while (numero != 0)
            {
                int digito = numero % 10; // saco el ultimo digito en una variable

                // Si el dígito es impar, agregarlo al resultado
                if (digito % 2 != 0) //si el el resto entre un numero dividido en 2 es 0, es par
                {
                    resultado += digito * potencia; // hace que el numero se vaya colocando delante 
                    potencia *= 10;
                }

                // Dividir el número por 10 para pasar al siguiente dígito
                numero /= 10;
            }

            Console.WriteLine("El resultado es: " + resultado);
        }


        ///////// STRINGS
        ///

        ///cuenta la cantidad de vocales de una palabra
        static void contarVocales()
        {
            Console.Write("Ingrese una palabra: ");
            string palabra = Console.ReadLine().ToLower(); // Convertir la palabra a minúsculas para comparar

            int contadorVocales = 0;

            foreach (char letra in palabra)
            {
                if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    contadorVocales++;
                }
            }

            Console.WriteLine("La palabra ingresada tiene " + contadorVocales + " vocales.");

        }

        ///contar cuantas palabras tiene una oracion
        static void contarPalabras()
        {
            Console.Write("Ingrese una oración: ");
            string oracion = Console.ReadLine();

            int contadorPalabras = 0;
            bool enPalabra = false;

            foreach (char caracter in oracion)
            {
                if (char.IsLetter(caracter))
                {
                    if (!enPalabra)
                    {
                        contadorPalabras++;
                        enPalabra = true;
                    }
                }
                else
                {
                    enPalabra = false;
                }
            }

            Console.WriteLine("La oración ingresada tiene " + contadorPalabras + " palabras.");
        }

        static bool existe(string oracion, string palabra)
        {        
            // Verificar si la palabra está en la oración
            bool palabraEnOracion = oracion.Contains(palabra);

            return palabraEnOracion;
        }



        /////////VECTORES///////////////////////
        static void LlenarVector(int cantidad)
        {

            int[] vector = new int[cantidad];
            int numero = 1;

            for (int i = 0; i < cantidad; i++)
            {
                while (!esPar(numero))
                {
                    numero++;
                }
                vector[i] = numero;
                numero++;
            }
            imprimirVector(vector);

        }

        static void llenarVectorString(string palabra)
        {
            char[] letras = new char[palabra.Length];

            for (int i = 0; i < palabra.Length; i++)
            {
                letras[i] = palabra[i];
            }

            Console.WriteLine("El vector llenado con las letras de la palabra es:");
            imprimirVector(letras);
        }

        static void llenarVectorPalabras(string oracion)
        {
            string[] palabras = oracion.Split(' ');

            Console.WriteLine("Las palabras de la oración en un vector son:");
            imprimirVector(palabras);
        }



        static T[] invertirVector<T>(T[] vector)
        {
            T[] vectorInvertido = new T[vector.Length];

            for (int i = 0; i < vector.Length; i++)
            {
                vectorInvertido[i] = vector[vector.Length - 1 - i];
            }

            return vectorInvertido;
        }


        static void imprimirVector<T>(T[] vector)
        {
            foreach (T elemento in vector)
            {
                Console.Write(elemento + " ");
            }
            Console.WriteLine();
        }

        /////////MATRICES///////////////////////

        //// Llenar la matriz con los números del 1 al 5 en cada fila
        static int[,] LlenarMatriz(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = 0; columna < columnas; columna++)
                {
                    matriz[fila, columna] = columna + 1; // Llenar la matriz con números del 1 al número de columnas
                }
            }

            return matriz;
        }
        //// Llenar la matriz con los números seguidos escalonada superior
        static int[,] LlenarMatrizEscalonadaSuperior(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas

            int numero = 1; // Inicializar el primer número a colocar

            for (int fila = 0; fila < filas; fila++)
            {
                for (int columna = fila; columna < columnas; columna++) // Comenzar a colocar números desde la diagonal superior
                {
                    matriz[fila, columna] = numero++; // Asignar el número actual y luego incrementarlo
                }
            }

            return matriz;
        }



        // Llenar la matriz con los números del 1 al 25 en forma de serpiente
        static int[,] LlenarMatrizSerpiente(int filas, int columnas)
        {
            int[,] matriz = new int[filas, columnas]; // Crear una matriz vacía con las dimensiones especificadas

            int valor = 1;
            for (int fila = 0; fila < filas; fila++)
            {
                // Determinar la dirección de llenado de la fila (izquierda a derecha o derecha a izquierda)
                bool derecha = fila % 2 == 0;

                // Llenar la fila en la dirección determinada
                if (derecha)
                {
                    for (int columna = 0; columna < columnas; columna++)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
                else
                {
                    for (int columna = columnas - 1; columna >= 0; columna--)
                    {
                        matriz[fila, columna] = valor++;
                    }
                }
            }

            return matriz;
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
    }
}