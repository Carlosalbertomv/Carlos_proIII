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
      //guardarDatosCompletos();
      //string le = "carlos es hola es todo mamama ";
      
      //Console.WriteLine(FindMostRepeatedWord(le));
      guardarDatosCompletos2();

    }

    static int ProductoDigitos(int numero)
    {
        int producto = 1;

        while (numero != 0)
        {
            int digito = numero % 10;
            producto *= digito;
            numero /= 10;
        }

        return producto;
    }

  

     static void guardarDatosCompletos()
     {
        string archivoEntrada = @"E:/UPC/carlos/Carlos_proIII/ExamenF/ArchivoEntrada.txt";

        string archivoSalida = @"E:/UPC/carlos/Carlos_proIII/ExamenF/ArchivoSalida.txt";


        try
        {
            using (StreamReader reader = new StreamReader(archivoEntrada))
            using (StreamWriter writer = File.AppendText(archivoSalida))
            {
                string linea;

                while ((linea = reader.ReadLine()) != null)
                {
                    int contadorVocales = EncontrarMenorDigito(linea);

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

    static int EncontrarMenorDigito(string numero)
    {
        // Convertir el número en una secuencia de caracteres y ordenarla
        var digitosOrdenados = numero.Where(char.IsDigit).OrderBy(c => c);

        // El menor dígito será el primer carácter de la secuencia
        return digitosOrdenados.First() - '0'; // Restamos '0' para convertir el carácter en el valor numérico correspondiente
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
        string archivoEntrada = @"E:/UPC/carlos/Carlos_proIII/ExamenF/ArchivoEntrada.txt";

        string archivoSalida = @"E:/UPC/carlos/Carlos_proIII/ExamenF/ArchivoSalida.txt";


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
                            int contadorVocales = ProductoDigitos(numero);

                    // Formatear la salida según el formato requerido
                    string salida = "D=> " + numero + " ; R=> " + contadorVocales + "";

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

    public static string EncontrarPalabraMasLarga(string cadena)
    {
        string[] palabras = cadena.Split(new char[] { ' ', ',', '.', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
        
        string palabraMasLarga = "";
        
        foreach (string palabra in palabras)
        {
            if (palabra.Length > palabraMasLarga.Length)
            {
                palabraMasLarga = palabra;
            }
        }
        
        return palabraMasLarga;
    }

    static string MasVocales(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string wordWithMostVowels = "";
        int maxVowelCount = 0;

        foreach (string word in words)
        {
            int vowelCount = CountVowels(word);
            if (vowelCount > maxVowelCount)
            {
                maxVowelCount = vowelCount;
                wordWithMostVowels = word;
            }
        }

        return wordWithMostVowels;
    }

    static int CountVowels(string word)
    {
        return word.ToLower().Count(c => "aeiou".Contains(c));
    }

    static string LetraRepetida(string sentence)
    {
        // Dividir la oración en palabras
        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        // Crear un diccionario para contar las repeticiones de cada palabra
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (string word in words)
        {
            // Convertir la palabra a minúsculas para evitar distinción entre mayúsculas y minúsculas
            string lowercaseWord = word.ToLower();

            if (wordCount.ContainsKey(lowercaseWord))
            {
                wordCount[lowercaseWord]++;
            }
            else
            {
                wordCount[lowercaseWord] = 1;
            }
        }

        // Encontrar la palabra con el recuento más alto
        string mostRepeatedWord = wordCount.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

        return mostRepeatedWord;
    }

    static string LetraCorta(string sentence)
    {
        string[] words = sentence.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Inicializar la palabra más corta con la longitud máxima posible
        string shortestWord = null;
        int shortestLength = int.MaxValue;

        foreach (string word in words)
        {
            if (word.Length < shortestLength)
            {
                shortestLength = word.Length;
                shortestWord = word;
            }
        }

        return shortestWord;
    }

    static Dictionary<int, int> ContarNumerosRepetidos(int[] numeros)
    {
        Dictionary<int, int> contador = new Dictionary<int, int>();

        foreach (int numero in numeros)
        {
            if (contador.ContainsKey(numero))
            {
                contador[numero]++;
            }
            else
            {
                contador[numero] = 1;
            }
        }

        return contador;
    }


    

    

    
 }
 
}