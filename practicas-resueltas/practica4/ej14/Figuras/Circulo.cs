namespace Figuras;
using  System;
public class Circulo
{
    double _radio;
    public Circulo(double radio){
        _radio = radio;
    }

    public double GetArea() => _radio*_radio * Math.PI;
}
