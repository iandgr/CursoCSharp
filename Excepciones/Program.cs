using System;

namespace Excepciones {
  internal class Program {
    static void Main(string[] args) {
      int numero1 = 0;
      int numero2 = 0;
      bool numerosValidos = true;
      // BLOQUE TRY - CATCH
      try {
        Console.WriteLine("Ingresa el primer numero");
        numero1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingresa el segundo numero");
        numero2 = int.Parse(Console.ReadLine());
      } catch(FormatException ex) { // Si el usuario ingresa un texto, el sistema lanza una exepcion del tipo FormatException
        Console.WriteLine($"Ocurrio un error de formato: {ex.Message}");
        numerosValidos = false;
      } catch(OverflowException ex) { // Si el usuario ingresa un numero demasiado grande para un int se genere un OverFlowException
        Console.WriteLine($"Ocurrio un error de almacenamieto: {ex.Message}");
        numerosValidos = false;
      } catch(Exception ex) { // Las excepciones general debemos ponerlos al final ya que sino descartaria a los demas especificas
        Console.WriteLine($"Ocurrio un error de almacenamieto: {ex.Message}");
        numerosValidos = false;
      }
      if(numerosValidos) {
        int resultado = numero1 + numero2;
        Console.WriteLine($"El resultado de la suma es {resultado}");
      } else {
        Console.WriteLine("No se pudo completar la suma");
      }
      
      // EXCEPCIONES CON FILTRO
      try {
        Console.WriteLine("Ingresa un numero de prueba");
        int n = int.Parse(Console.ReadLine());
      } catch(Exception ex) when(ex.GetType() != typeof(FormatException)) { // Se dice que capturen todas excepciones expecto la que sea del tipo Format
        Console.WriteLine("Ha ocurrido un error general");
      } catch(FormatException) { // De esta forma, la excepcion mas especifica puede ir despues de la general
        Console.WriteLine("Ha ocurrido un excepcion de formato");
      }
      
      //// CHECKED (solo funciona sobre tipos de datos int y long)
      //checked { // El checked fuerza al compilador a evaluar las excepciones de desbordamiento aritmetico que pudieran generarse en ese bloque de codigo
      //  int num1 = int.MaxValue; // Asigname a num1 el valor maximo que puede tener un int en C#
      //  // El checked tambien se puede utilizar en una sola expresion
      //  int res = checked(num1 + 25); // Esta expresion deberia desbordar el valor maximo que puede tener un int
      //  Console.WriteLine(res); // Sin embargo el compilador por un tema de rendimiento ignora este tipo de desbordamientos en operaciones aritmeticas
      //} // El unchecked funciona a la inversa cuando el chequeo de desbordamientos aritmeticos esta activado en todo el proyecto
     
      // LANZAR EXCEPCIONES CON THROW
      Console.WriteLine("Ingresa el numero de mes");
      int nMes = int.Parse(Console.ReadLine());
      try {
        Console.WriteLine(NombreDelMes(nMes));
      } catch(Exception ex) {
        Console.WriteLine(ex.Message);
      }
      Console.WriteLine("Aqui continua la ejeccucion del programa...");

      // USO DE FINALLY ABRIENDO UN ARCHIVO .txt
      System.IO.StreamReader sr = null;
      try {
        string linea;
        int contador = 0;
        string ruta = @"C:\\Users\\Ian\\Desktop\\tirar.txt";
        sr = new System.IO.StreamReader(ruta);
        while((linea = sr.ReadLine()) != null) { // mientras haya caracteres por leer en el fichero
          Console.WriteLine(linea);
          contador++;
        }
      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
      } finally { // El codigo del finally siempre se ejecuta, ya sea entre en el catch o se cumpla el try
        // Es recomendable cerrar las conexiones a ficheros y las bases de datos en el finally
        if (sr != null) sr.Close();
        Console.WriteLine("Conexion con el fichero cerrada");
      }
    }
    public static string NombreDelMes(int nMes) {
      switch(nMes) {
        case 1:
          return "Enero";
        case 2:
          return "Febrero";
        case 3:
          return "Marzo";
        case 4:
          return "Abril";
        case 5:
          return "Junio";
        case 6:
          return "Julio";
        case 7:
          return "Mayo";
        case 8:
          return "Agosto";
        case 9:
          return "Septiembre";
        case 10:
          return "Octubre";
        case 11:
          return "Noviembre";
        case 12:
          return "Diciembre";
        default:
          throw new ArgumentOutOfRangeException(nameof(nMes), "El numero de mes debe estar entre 1 y 12.");
          // Arroja una nueva excepcion cuando numero de mes no esta entre 1 y 12 y muestra que parametro causa la excepcion y un mensaje
      }
    }
  }
}