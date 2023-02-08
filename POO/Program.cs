using static System.Math; // Se importan todos los metodos static de la clase Math 

namespace POO {
  internal class Program {
    static void Main(string[] args) {
      // USO CLASE CIRCULO
      Circulo c1; // crear o declarar un objeto
      c1 = new Circulo(); // inicializar un objeto o instanciar una clase
      Circulo c2 = new Circulo(); // se pueden hacer ambas cosas en la misma linea
      Console.WriteLine(c1.CalculoArea(5)); // uso del metodo CalculoArea, es necesario cambiar el modificador de acceso, en esto caso se uso public
      Console.WriteLine(c2.CalculoArea(9));
      // USO CLASE CONVERSOR EURO DOLAR
      ConversorEuroDolar ced = new ConversorEuroDolar();
      Console.WriteLine(ced.Convertir(50));
      ced.CambiarValorEuro(1.5);
      Console.WriteLine(ced.Convertir(50));
      //ced.CambiarValorEuro(-8); // arroja una excepcion
      // CONSTRUCTORES EJEMPLO
      Coche coche1 = new Coche(); // se llama al constructor de Coche
      Console.WriteLine(coche1.GetInfo());
      Coche coche2 = new Coche(4500.25, 1200.35);
      Console.WriteLine(coche2.GetInfo());
      // GETTERS Y SETTERS EJEMPLO
      coche1.SetClimatizador(true);
      coche1.SetTapiceria("cuero");
      Console.WriteLine(coche1.GetClimatizador());
      Console.WriteLine(coche1.GetTapicera());
      // USO DE FICHEROS FUENTE EXTERNO
      Punto punto1 = new Punto();
      Punto punto2 = new Punto(150, 90);
      Console.WriteLine(punto1.DistaciaHasta(punto2));
      // STATIC EN VARIABLES, METODOS Y CONSTANTES
      Console.WriteLine(Punto.GetContadorDeObjetos());
      Console.WriteLine(Punto.PRUEBA);
      // IMPORTAR METODOS STATIC
      double raiz = Sqrt(9); // no es es necesario llamar a la clase ahora debido a que se importaron en el using (puede causar confusion)
      // CLASES ANONIMAS
      // - Solo pueden contener campos publicos
      // - Todos los campos deben ser iniciados
      // - Los campos no pueden ser static
      // - No se pueden definir metodos
      // El compilador da un tipo/clase al objeto la cual no sabemos pero no necesitamos
      var miObjeto = new { Nombre = "Ian", Edad = 26 }; // Se crea un objeto sin tipo (var) y se inician sus atributos en un bloque despues de "new"
                                                        // El tipo de los campos es determinando por el valor que lo inicializa
      Console.WriteLine(miObjeto.Nombre);
      Console.WriteLine(miObjeto.Edad);
      var miOtroObjeto = new { Nombre = "Naomi", Edad = 20 }; // Para el compilador "miObjeto" y "miOtroObjeto" son del mismo tipo/clase ya que se basa
                                                              // en el numero de campos, el tipo de los campos y el orden de los campos
      miObjeto = miOtroObjeto; // Debido a que para el compilador son de la misma clase, es posible hacer esta asignacion
    }
  }
  class Circulo {
    // private viene por defecto en c# (accesible solo dentro de la clase)
    private const double PI = 3.1416; // propiedad de la clase Circulo
    public double CalculoArea(int radio) { // metodo de la clase Circulo. public la hace accesible fuera de clase
      return radio * radio * PI;
    }
  }
  class ConversorEuroDolar {
    private double euro = 1.253; // valor del euro con respecto al dolar
    public double Convertir(double cantidad) => cantidad * euro;
    // Es recomendable modificar las propiedades de clase como "euro" unicamente mediante "metodos de acceso"
    public void CambiarValorEuro(double nuevoValor) {
      // nos aseguramos que el nuevo valor del euro no pueda ser menor que 0.
      if(nuevoValor > 0) {
        euro = nuevoValor;
      } else {
        throw new ArgumentOutOfRangeException(nameof(nuevoValor), "El valor de un moneda respecto a la otra no puede ser negativa.");
      }

    }
  }
  // CONSTRUCTORES
  partial class Coche {
    public Coche() { // Constructor de la clase Coche (define un estado inicial)
      ruedas = 4;
      largo = 2300.5;
      ancho = 0.800;
      tapiceria = "tela";
    }
    // Sobrecarga de constructores
    public Coche(double nLargo, double nAncho) {
      ruedas = 4;
      largo = nLargo;
      ancho = nAncho;
      tapiceria = "tela";
    }
  }
  // -----------------------------------------------------separacion de una clase en partes-------------------------------------------------------------------------//
  partial class Coche {
    // GETTERS Y SETTERS
    public int GetRuedas() => ruedas; // metodo get para retornar el numero de ruedas
    public void SetClimatizador(bool nClimatizador) { climatizador = nClimatizador; } // metodo set para el climatizador
    public void SetTapiceria(string nTapiceria) { tapiceria = nTapiceria; } // metodo set para la tapiceria
    public void SetLargo(double largo) { this.largo = largo; } // uso del this para casos donde el parametro se llame igual que el campo de clase
    public bool GetClimatizador() => climatizador; // metodo get para el climatizador
    public String GetTapicera() => tapiceria; // metodo get para la tapiceria
    public String GetInfo() => $"Ruedas: {ruedas}; Largo: {largo}; Ancho: {ancho}";
    public void Manejar() {
      // TODO: Este comentario aparecera en la vista de tarea como una tarea pendiente
    }
    private int ruedas;
    private double largo;
    private double ancho;
    private bool climatizador;
    private String tapiceria;
  }

}