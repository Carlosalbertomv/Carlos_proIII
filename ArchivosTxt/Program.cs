using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      string ruta = @"E:/UPC/carlos/Carlos_proIII/ArchivosTxt/CarlosAlberto.txt";
      
      FileStream archivo = null;
      archivo = File.Open(ruta, FileMode.OpenOrCreate);
    }

    
 }
 
}