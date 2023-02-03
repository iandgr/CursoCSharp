namespace Condicionales {
  internal class Program {
    static void Main(string[] args) {
      // if
      Console.WriteLine("Ingresa tu edad");
      int edad = int.Parse(Console.ReadLine());
      if(edad >= 18) {
        Console.WriteLine("Tienes licencia de conducir?");
        string licencia = Console.ReadLine();
        if(licencia == "si") {
          Console.WriteLine("Puedes manejar!");
        } else {
          Console.WriteLine("No puedes manejar porque no tienes licencia");
        }
      } else {
        Console.WriteLine("No puedes conducir porque eres menor de edad");
      }
      // else if
      int numero = 10;
      if(numero < 10) Console.WriteLine("menos de 10");
      else if(numero < 20) Console.WriteLine("Menos de 20");
      else if(numero < 30) Console.WriteLine("Menos de 30");
      else {
        Console.WriteLine("Mas de 30");
      }
      // switch (solo se pueden evaluar int, char y string
      int num = 3;
      switch(num) {
        case 1:
          Console.WriteLine("Es uno"); // solo se puede comparar con una constante y deben ser unicas
          break; // el break es obligatorio para cada case
        case 2:
          Console.WriteLine("Es dos");
          break;
        case 3:
          Console.WriteLine("Es tres");
          break;
        case 4:
          Console.WriteLine("Es cuatro");
          break;
        default:
          Console.WriteLine("Es otro numero");
          break;
      }
    }
  }
}