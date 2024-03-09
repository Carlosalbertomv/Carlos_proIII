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
        intercambio(numeros);

      
     
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
       imprimirCambio(cambio);

    }
    

   
 }
 
}