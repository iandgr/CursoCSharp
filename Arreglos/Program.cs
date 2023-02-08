namespace Arreglos {
  internal class Program {
    static void Main(string[] args) {
      //UsoArrays();
      //UsoArraysImplicitosYDeObjetos();
      //UsoBucleForArrays();
      UsoArraysEnMetodos();
    }
    public static void UsoArrays() {
      int[] edades; // Declarar el array
      edades = new int[4]; // Inicializar el array
      edades[0] = 10; // Asigancion de valores
      edades[1] = 20;
      edades[2] = 30;
      edades[3] = 40;
      //edades[4] = 50; // Index.OutOfRangeException: El index 4 no existe el arreglo
      Console.WriteLine(edades[2]); // 30
      int[] numeros = { 23, 45, 67, 87, 500 }; // Declarar, iniciar y asignar valores en la misma linea
    }
    public static void UsoArraysImplicitosYDeObjetos() {
      // Arrays implicitos
      var datos = new[] { "Ian", "Garay", "Mexico" }; // Asigna el tipo dependiendo los elementos que contiene (string en este caso)
      var valores = new[] { 15, 28, 35, 75.6, 30.33 }; // Aqui le da un tipo double

      // Arrays de objetos
      Empleados anna = new Empleados("Anna", 27);
      Empleados[] arrayEmpleados = new Empleados[2];
      arrayEmpleados[0] = new Empleados("Sara", 37); // Se instancia el objeto a la vez que se asigna al array
      arrayEmpleados[1] = anna; // Se asigna un objeto ya creado al array

      // Array de tipos o clases anonomias
      var personas = new[] { // El nombre de los campos, el numero de campos y el tipo de estos, debe ser el mismo.
        new{nombre = "Juan", edad = 27},
        new{nombre = "Maria", edad = 49},
        new{nombre = "Diana", edad = 35}
      };
      Console.WriteLine(personas[1]); // {nombre = "Maria", edad = 49}
    }
    public static void UsoBucleForArrays() {
      // Array valores (implicito)
      var valores = new[] { 15, 28, 35, 75.6, 30.33 };
      // Array empleados (objetos)
      Empleados anna = new Empleados("Anna", 27);
      Empleados[] arrayEmpleados = new Empleados[2];
      arrayEmpleados[0] = new Empleados("Sara", 37);
      arrayEmpleados[1] = anna;
      // Array personas (clases anonimas)
      var personas = new[] {
        new{nombre = "Juan", edad = 27},
        new{nombre = "Maria", edad = 49},
        new{nombre = "Diana", edad = 35}
      };
      // BUCLE FOR
      for(int i = 0; i < valores.Length; i++) {
        Console.WriteLine(valores[i]);
        //15
        //28
        //35
        //75.6
        //30.33
      }
      for(int i = 0; i < arrayEmpleados.Length; i++) {
        Console.WriteLine($"{arrayEmpleados[i].GetNombre()}, {arrayEmpleados[i].GetEdad()}");
        //Sara, 37
        //Anna, 27
      }
      // BUCLE FOR EACH
      // Se debe recorrer usando un elemento del mismo tipo que es el arreglo
      foreach(Empleados element in arrayEmpleados) {
        Console.WriteLine(element.GetNombre());
        //Sara
        //Anna
      }
      // El foreach sirve especialmente para arrays de objetos con clase anonima
      foreach(var element in personas) {
        Console.WriteLine(element.nombre);
        //Juan
        //Maria
        //Diana
      }
    }
    // USO DE ARRAYS POR PARAMETROS
    public static void UsoArraysEnMetodos() {
      int[] numeros = new int[4];
      numeros[0] = 7;
      numeros[1] = 9;
      numeros[2] = 15;
      numeros[3] = 3;
      ProcesaDatos(numeros); // Se envia el array por parametro
    }
    public static void ProcesaDatos(int[] datos) { // Se especifica que recibe un array de tipo int (LOS ARRAYS SIEMPRE SE PASAN POR REFERENCIA)
      // Recorre el arreglo recibido
      foreach(int element in datos) {
        Console.WriteLine(element);
        //7
        //9
        //15
        //3
      }
      // Ejemplo aumentar 10 a cada elemento del arreglo
      for(int i = 0; i < datos.Length; i++) {
        datos[i] += 10;
        Console.WriteLine(datos[i]);
        //17
        //19
        //25
        //13
      }
      // USO DE ARRAY EN EL RETURN
      int[] arregloNumeros = LeerDatos();
      Console.WriteLine("Los datos que ingresaste en el arreglo:");
      foreach(int element in arregloNumeros) {
        Console.WriteLine(element);
      }
    }
    // Metodo para crear y llenar un arreglo de enteros segun lo que se pida por consola
    public static int[] LeerDatos() {
      Console.WriteLine("Cuantos elementos quieres que tenga el arreglo?");
      int n = int.Parse(Console.ReadLine());
      int[] elementos = new int[n];
      for(int i = 0; i < elementos.Length; i++) {
        Console.WriteLine($"Ingresa el valor para el elemento [{i}]");
        elementos[i] = int.Parse(Console.ReadLine());
      }
      return elementos;
    }
  }
  class Empleados {
    private String nombre;
    private int edad;
    public Empleados(string nombre, int edad) {
      this.nombre = nombre;
      this.edad = edad;
    }
    public String GetNombre() => nombre;
    public int GetEdad() => edad;
  }
}