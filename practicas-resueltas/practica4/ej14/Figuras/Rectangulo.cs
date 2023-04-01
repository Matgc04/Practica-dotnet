namespace Figuras;
public class Rectangulo
{
    double _base;
    double _altura;
    public Rectangulo(double b, double h){
        _altura = h;
        _base = b;
    }
    public double GetArea() => _altura*_base;
}