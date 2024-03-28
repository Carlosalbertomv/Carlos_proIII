using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      /*string ruta = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/CarlosAlberto.txt";
      
      FileStream archivo = null;
      archivo = File.Open(ruta, FileMode.OpenOrCreate);*/
      //datosAlFinal();
      guardarDatosCompletos2();
    }

    static void LeerArchivo()
    {
      try
      {
        string rutaArchivo = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/CarlosAlberto.txt";

        StreamReader reader = new StreamReader(rutaArchivo);

        string linea;

        while ((linea = reader.ReadLine()) != null)
        {
          Console.WriteLine(linea);
        }
      }

      catch(Exception ex)
      {
        Console.WriteLine("Error al leer el archivo: " + ex.Message);
      }
    }

    static void datosAlFinal()
    {
            // Definir la ruta del archivo
            string rutaArchivo = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/CarlosAlberto.txt";

            StreamWriter writer = File.AppendText(rutaArchivo);

            // Escribir datos adicionales en el archivo
            writer.WriteLine("Nuevo dato agregado al final del archivo");
            Console.WriteLine("Datos agregados al final del archivo con éxito.");


            // Cerrar el archivo explícitamente
            writer.Close();


            // Borrar el archivo
            //File.Delete(rutaArchivo);
     }

     static void guardarDatosCompletos()
     {
        string archivoEntrada = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/archivo_entrada.txt";

        string archivoSalida = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/archivo_salida.txt";


        try
        {
            using (StreamReader reader = new StreamReader(archivoEntrada))
            using (StreamWriter writer = File.AppendText(archivoSalida))
            {
                string linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    int contadorVocales = ContarPalabras(linea);

                    // Formatear la salida según el formato requerido
                    string salida = "D=> " + linea + " ; R=> " + contadorVocales + "";

                    // Escribir la salida en el archivo de salida
                    writer.WriteLine(salida);
                }
            }

            Console.WriteLine("Proceso completado. Se ha creado el archivo de salida.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static int ContarVocales(string cadena)
    {
        int contador = 0;

        // Convertir la cadena a minúsculas para hacer el conteo de manera insensible a mayúsculas/minúsculas
        cadena = cadena.ToLower();

        // Contar las vocales (a, e, i, o, u) en la cadena
        foreach (char caracter in cadena)
        {
            if (caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
            {
                contador++;
            }
        }

        return contador;
    }

    static int ContarPalabras(string texto)
    {
        if (string.IsNullOrWhiteSpace(texto))
            return 0;

        int cantidadPalabras = 0;

        // Separar el texto en palabras usando los espacios en blanco como delimitadores
        string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Contar la cantidad de palabras encontradas
        cantidadPalabras = palabras.Length;

        return cantidadPalabras;
    }

    static void guardarDatosCompletos2()
     {
        string archivoEntrada = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/archivo_entrada.txt";

        string archivoSalida = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/archivo_salida.txt";


        try
        {
            using (StreamReader reader = new StreamReader(archivoEntrada))
            using (StreamWriter writer = File.AppendText(archivoSalida))
            {
                string linea;

                while ((linea = reader.ReadLine()) != null)
                    {
                        // Convertir la línea a un número entero
                        if (int.TryParse(linea, out int numero))
                        {
                            bool EsPrimo = esPrimo(numero);
                            string resultado = EsPrimo ? "es primo" : "no es primo";

                            // Formatear la salida según el formato requerido
                            string salida = $"{numero} {resultado}";

                            // Escribir la salida en el archivo de salida
                            writer.WriteLine(salida);
                        }
                        else
                        {
                            Console.WriteLine($"'{linea}' no es un número válido y será omitido.");
                        }
                    }
                }

                Console.WriteLine("Proceso completado. Se ha creado el archivo de salida.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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

    
 }
 
}