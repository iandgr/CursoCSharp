namespace POO {
  internal class Punto {
    private int x;
    private int y;
    private static int contadorDeObjetos = 0; // Cuenta el numero de objetos creados de esta clase aprovechando que
                                              // una variable static es la misma para todos las intencias de un clase
    public const int PRUEBA = 1; // Las constantes son por defecto static sin necesidad de indicarlo
    public Punto() {
      this.x = 0;
      this.y = 0;
      contadorDeObjetos++;
    }
    public Punto(int x, int y) {
      this.x = x;
      this.y = y;
      contadorDeObjetos++;
    }
    public double DistaciaHasta(Punto otroPunto) {
      int xDif = this.x - otroPunto.x;
      int yDif = this.y - otroPunto.y;
      double distancia = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2)); // teorema de pitagoras
      return distancia;
    }
    public static int GetContadorDeObjetos() => contadorDeObjetos; // Metodo que se puede usar desde la clase misma sin necesidad de instanciar
                                                                   // un objeto
  }
}
