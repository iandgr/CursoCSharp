namespace PracticaMetodos {
  internal class Program {
    void MetodoUno() { // Por nomenclatura, los nombre de metodos empiezan con mayuscula
      Console.WriteLine(numero1); // No produce error a pesar que numero 1 esta fuera del metodo y es declarado despues en el flujo
    }
    int numero1 = 5; // variable con ambito de clase accesibles por cualquier metodo de la clase
    static int SumaNumeros(int n1, int n2) {
      return n1 + n2;
    }
    static int SumaNumerosR(int n1, int n2) => n1 + n2; // Nos ahorramos el return y las llaves, solo cuando es una linea de codigo
    static void MensajeEnPantalla() { // el metodo debe ser static para ser llamado sin utilizar un objeto
      Console.WriteLine("Mensaje desde el metodo");
    }
    // SOBRECARGA DE METODOS
    static int Suma(int n1, int n2) => n1 + n2;
    static int Suma(int n1, int n2, int n3) => n1 + n2 + n3;
    static double Suma(int n1, double n2) => n1 + n2;
    static int Suma() => 0;
    // PARAMETROS OPCIONALES
    // LOS PARAMETROS OBLIGATARIOS SIEMPRE DEBEN IR PRIMERO QUE LOS OPCIONALES
    static int Resta(int n1, int n2, int n3 = 0, int n4 = 0) => n1 - n2 - n3 - n4;
    static int Resta(int n1, int n2) => n1 - n2;
    // METODO MAIN
    static void Main(string[] args) {
      MensajeEnPantalla();
      Console.WriteLine("Mensaje desde el main");
      MensajeEnPantalla();
      Console.WriteLine("Ingresa el 1er numero");
      int n1 = int.Parse(Console.ReadLine());
      Console.WriteLine("Ingresa el 2do numero");
      int n2 = int.Parse(Console.ReadLine());
      int res = SumaNumerosR(n1, n2);
      Console.WriteLine($"El resultado es: {res}");
      // USO DE LA SOBRECARGA DE METODOS
      Console.WriteLine(Suma());
      // USO DE PARAMETROS OPCIONALES
      Console.WriteLine(Resta(20,10)); // EN CASO DE AMBIGUEDAD, SE LLAMARA AL QUE MAS SE ASEMEJE AL NUMERO DE PARAMETROS
    }
  }
}