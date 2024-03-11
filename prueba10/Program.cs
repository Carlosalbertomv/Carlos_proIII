using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Console.WriteLine("ingrese primera nota");
      double nota1 = Convert.ToDouble(Console.ReadLine());
      
      Console.WriteLine("ingrese segunda nota");
      double nota2 = Convert.ToDouble(Console.ReadLine());

      double promedio = (nota1 + nota2) / 2;

      Console.WriteLine($"El promedio de las 2 notas es: {promedio}");*/

      //rotar();
      //rotar2(); 
      FiltrarDigitosImpares(numero);
      Console.ReadLine();


      
     
    }

    static void rotar()
    {
      string numero = Console.ReadLine();
      char ultimo = numero[numero.Length - 1];
      string resto = numero.Substring(0, numero.Length - 1);
      string resultado = ultimo + resto;
      Console.WriteLine(resultado);
    }

    static void rotar2()
    {
      string numero = Console.ReadLine();
      char primero = numero[0];
      char segundo = numero[1];
      string resto = numero.Substring(2, numero.Length - 2);
      string resultado = resto + primero + segundo;
      Console.WriteLine(resultado);

      
    }

    //PRACTICA
    static void imprimirVector(int[] vector)
    {
        string vectorString = "";
        foreach(int elemento in vector) {
            vectorString = vectorString + elemento + " ";
        }

        Console.WriteLine(vectorString);
    }

    static void FiltrarDigitosImpares(int numero)
    {
      int resultado = 0;
      int potencia = 1;

      while (numero != 0)
      {
        int digito = numero % 10;
        if (digito % 2 != 0)
        {
          resultado += digito * potencia;
          potencia *= 10;
        }
        numero /= 10;
      }
      Console.WriteLine("El resultado es: " + resultado);
      imprimirVector(numero);

    } 
 }
 
}