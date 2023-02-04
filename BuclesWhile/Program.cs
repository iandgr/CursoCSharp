namespace BuclesWhile {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Deses entrar al blucle While?");
      string res = Console.ReadLine();
      int n = 0;
      while(res != "no") {
        n++;
        Console.WriteLine($"Ejeccion numero {n} del bucle\nDeseas repetir el bucle?");
        res = Console.ReadLine();
      }
      Console.WriteLine("Saliste del bucle while");
      // EJERCICIO
      /* Crea un algoritmo en el que se genere un numero aleatorio, despues el usuario debe intentar adivinar dicho numero
       * aleatorio, cada vez que falle el programa debe decirle si dicho numero es mayor o menor que el que respondio, cuando el usuario adivine
       * numero, el programa debe decirle que lo adivino y el numero de intento que tuvo que realizar y por ultimo finalizar la ejeccion
       */
      Random numero = new Random();
      int numAleatorio = numero.Next(0, 100); // genera un numero aleatorio entre 0 y 100
      bool adivino = false;
      int intentos = 0;
      int numElegido;
      Console.WriteLine("Ingresa un numero");
      while(!adivino) {
        numElegido = int.Parse(Console.ReadLine());
        if(numElegido == numAleatorio) adivino = true;
        else if(numElegido < numAleatorio) Console.WriteLine("Ingresa un numero mas grande");
        else if(numElegido > numAleatorio) Console.WriteLine("Ingresa un numero mas chico");
        intentos++;
      }
      Console.WriteLine($"Adivinaste el numero en {intentos} intentos");
      // DO WHILE (se ejecuta al menos una vez)
      int z = 10;
      do {
        Console.WriteLine($"impresion {z}");
        z++;
      } while(z < 10);
    }
  }
}