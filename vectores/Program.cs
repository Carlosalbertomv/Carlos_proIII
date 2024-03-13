using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {   //vectores de numeros 
        int[] numeros = new int[] {1,2,3,4,5,6,7,8};
        //imprimirVector(numeros);
        //vectores de letras 
        char[] letras = new char[] {'a','b','c','d','e'};
        //vectores de palabras
        string[] palabras = new string[] {"hola","insanos","hello","hola","mundo"};

        //generar un vector vacio
        /*int[] vacio = new int[10];
        Console.WriteLine("\nVector vacio:");
        imprimirVectorVacio(vacio);*/

    
        //imprimirCambio();
        //intercambio(numeros);
        int[] vector = {1,2,3,4,5};
        sumaVectorImparYPar(vector);
        multiplosDe3(vector);
       //LlenarVector(vector);

       string palabra = Console.ReadLine();
       llenarVectorString(palabra);
      
     
    }

    static void imprimirVector(int[] vector)
    {
        string vectorString = "";
        foreach(int elemento in vector) {
            vectorString = vectorString + elemento + " ";
        }

        Console.WriteLine(vectorString);
    }

    static void imprimirCambio()
    {
       
       int[] numeros = {1,2,3,4,5,6,7,8};
       imprimirVector(numeros);
       numeros[2] = 15;
       imprimirVector(numeros);

    }
    
     static void intercambio(int[] cambio)
    {
       
       int temp = cambio[3];
       cambio[3] = cambio[2];
       cambio[2] = temp;
       Console.WriteLine("\n vector con posicion de intercambio: ");
       imprimirVector(cambio);

    }

    static void sumavector(int[] vector)
    {
        int suma = 0;
        foreach(int elemento in vector) {
            suma = suma + elemento;
            if (elemento > 4)
            {
                break;
            }
        }

        Console.WriteLine(suma);
    }

    static void sumaVectorImpar(int[] vector)
    {
        int suma = 0;
        foreach(int elemento in vector) {
            
            if ((elemento % 2) != 0)
            {
                suma = suma + elemento;
            }
        
        }

        Console.WriteLine(suma);
    }

    static void sumaVectorPar(int[] vector)
    {
        int suma = 0;
        foreach(int elemento in vector) {
            
            if ((elemento % 2) == 0)
            {
                suma = suma + elemento;
            }
        
        }

        Console.WriteLine(suma);
    }

    static void sumaVectorImparYPar(int[] vector)
    {
        int par= 0;
        int impar=0;

        foreach(int elemento in vector) {
            
            if ((elemento % 2) == 0)
            {
                par = par + elemento;
            }

            else
            {
                impar = impar + elemento;
            }
            
        
        }

        Console.WriteLine("la suma de pares es: " + par + "\nla suma de impares es: " + impar);
    }

    static void multiplosDe3(int[] vector)
    {
        int suma = 0;
        foreach(int elemento in vector) {
            
            if ((elemento % 3) == 0)
            {
                suma = suma+1 ;
            }
        
        }

        Console.WriteLine(suma);
    }
    // tarea de pa mañana martes
    /*/static void Recorrer(int[] vector, int numero, int posicion)
    {
        int numero = 10;
        int posicion = 1;
        for ()

        Console.WriteLine(suma);
    }*/

    /*static void LlenarVector(int cantidad)
    {
        int[] vector = new int[cantidad];
        int numero = 1;

        for (int i = 0; i < cantidad; i++)
        {
            while (!sumaVectorPar(numero))
            {
                numero++;
            }

            vector[i] = numero;
            numero++;
        }

        imprimirVector(vector);
    }

    static bool esPrimo(int numero)
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

    static void LlenarVectoresprimo(int cantidad)
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
    }*/

    //ver par
    static bool esPar(int numero)
    {
        if ((numero % 2)==1)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
    // imprimir letras
    static void imprimirVectorLetras(char[] vector)
    {
        string vectorString = "";
        foreach(int elemento in vector) {
            vectorString = vectorString + elemento + " ";
        }

        Console.WriteLine(vectorString);
    }

    static void llenarVectorString(string palabra)
    {
        char[] letras = new char[palabra.Length];
        for (int i = 0; i < palabra.Length; i++)
        {
            letras[i] = palabra[i];
        }

        imprimirVectorLetras(letras);
       
    }


    



    


    

   
 }
 
}