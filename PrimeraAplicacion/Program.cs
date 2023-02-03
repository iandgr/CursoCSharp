using System;
namespace PrimeraAplicacion {
  internal class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hola mundo con C#"); // Esto imprime un mensaje en consola
      /* TIPOS DE DATOS (MAS UTILIZADOS)
       * int : numeros enteros
       * long : numeros enteros muy grandes
       * float : numeros decimales
       * double : numeros decimales con parte decimal larga
       * decimal: numeros decimales con parte decimal muy larga
       * string : cadena de caracteres
       * char : un unico caracter
       * bool : booleanos */
      int edadAlumno; // Declarar una varibale
      edadAlumno = 18; // Inicializar una variable
      int edadProfesor = 40; // Declarar e inicializar una variable
      // NOTA: EN C# NO SE PUEDE UTILIZAR UNA VARIABLE SINO SE HA INICIALIZADO
      Console.WriteLine(edadProfesor + edadAlumno);
      /* OPERADORES ARITMETICOS
       * suma/concatenacion : +
       * resta : -
       * multiplicacion : *
       * division : /
       * modulo : %
       * incremento : ++ , +=
       * decremento : -- , -=
       */
      Console.WriteLine(5 / 2); // 2
      Console.WriteLine(5.0 / 2.0); // 2.5
      Console.WriteLine(5 / 2.0); // 2.5
      Console.WriteLine("Tienes una edad de " + edadAlumno + " anios"); // Concatenacion de strings
      Console.WriteLine($"Tienes una edad de {edadAlumno} anios"); // Interpolacion de strings
      // Declarar multiples variables del mismo tipo
      int edadPersona1, edadPersona2, edadPersona3;
      // Inicializar multiples variables con el mismo valor
      edadPersona1 = edadPersona2 = edadPersona3 = 18;
      // Declaracion implicita de variable
      int numero = 20;
      var edadPersona = numero; // Se le asigna el tipo int en tiempo de ejecucion
      // Conversion explicita e implicita
      double temperatura1 = 35.9;
      int temperatura2;
      // CONVERSION EXPLICITA (casting de double a int con perdida de informacion)
      temperatura2 = (int) temperatura1;
      Console.WriteLine(temperatura2); // 35
      // CONVERSION IMPLICITA (de int a long)
      int habitantes2019 = 100000;
      long habitantes2020 = habitantes2019;
      // CONVERSION IMPLICITA (de float a double)
      float pesoMaterial1 = 5.78f; // los valores float deben terminar con el subfijo 'f'
      double pesoMaterial2 = pesoMaterial1;
      // CONVERSION DE TIPOS NO COMPATIBLES (string a numero)
      Console.WriteLine("Introduce el 1er numero");
      // int.Parse convierte un string a int
      int num1 = int.Parse(Console.ReadLine()); // el metodo ReadLine() devuelve un objeto string
      Console.WriteLine("Introduce el 2do numero");
      int num2 = int.Parse(Console.ReadLine());
      Console.WriteLine($"El resultado es: {num1 + num2}");
      // CONSTANTES
      const int VALOR1 = 50; // Las constantes deben declararse e inicializar en la misma linea
      const int VALOR2 = 40;
      // Otra forma de imprimir por consola utilizando parametros
      Console.WriteLine("El valor 1 es: {0} y el valor 2 es: {1}", VALOR1, VALOR2); // Escribir 'cw' y presionar tab 2 veces = Console.WriteLine()
      // CALCULAR EL AREA DE UN CIRCULO
      const double PI = 3.1416;
      double radio;
      Console.WriteLine("Introduce el radio del circulo");
      radio = double.Parse(Console.ReadLine());
      double area = PI * (radio * radio); // Forma basica de calcular
      Console.WriteLine($"El area del circulo es de: {area}");
      area = Math.PI * Math.Pow(radio, 2); // Forma mas exacta usando la clase predefinida Math
      Console.WriteLine($"El area del circulo es de: {area}");
    }
  }
} 
