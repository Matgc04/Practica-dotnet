namespace practica4;
using static System.Console;
using System.Collections;
//ej 2 y 3
class Persona{
    private int _edad;
    private string? _nombre;
    private int _dni;
    public static int Idx = 0;

    public Persona(string nombre, int edad,  int dni){
        _edad = edad;
        _nombre = nombre;
        _dni = dni;
    }
    public void Imprimir(){
        if(Idx>0)
            Write($"{Idx,5}) {_nombre,12} {_edad,10} {_dni,10}");
        else
            Write($"{_nombre,1} {_edad,10} {_dni,10}");
        WriteLine("");
    }
    public bool EsMayorQue(Persona p) => _edad > p._edad;
}

//ej4 y 5
class Hora{

    private int _hora;
    private int _minuto;
    private int _segundo;
    private decimal _segundoD = decimal.MinValue;
    public Hora(int h, int m, int s){
        _hora = h;
        _minuto = m;
        _segundo = s;
    }
    public Hora(double horario){
        _hora = (int)horario;
        decimal aux =(decimal) (6*(horario - _hora)*10); //agarro minutos y segundos parte decimal
        _minuto = (int) aux;
        _segundoD = 6*(aux -_minuto)*10;
    }
    public void Imprimir(){
        if (_segundoD == decimal.MinValue)
            WriteLine($"{_hora} horas, {_minuto} minutos y {_segundo} segundos");
        else 
            WriteLine($"{_hora} horas, {_minuto} minutos y {_segundoD:0.000} segundos");
    }
}

//ej6
class Ecuacion2 {
    private double a;
    private double b;
    private double c;

    public Ecuacion2(double a, double b, double c){
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double GetDiscriminante(){
        return (b*b)-4*a*c;
    }
    public int GetCantidadDeRaices() => (GetDiscriminante()<0) ? 0 : (GetDiscriminante()>0) ? 2 : 1;

    public void ImprimirRaices(){
        switch (GetCantidadDeRaices())
        {
            case 2: 
                double raiz = (Math.Sqrt(GetDiscriminante() )-b)/(2*a);
                WriteLine($"raiz 1: {raiz}, raiz 2: {-raiz}");
                break;
            
            case 1:
                raiz = (Math.Sqrt(GetDiscriminante())-b)/(2*a);
                WriteLine($"raiz {raiz}");
                break;
            default:
                WriteLine("No hay raices reales");
                break;
        }
             
    }
}

//ej7
public class Nodo {
    private Nodo? _HD;
    private Nodo? _HI;
    private int _valor;

    public Nodo(int valor){
        _valor = valor;
        _HD=null;
        _HI=null;
    }
    // public void Insertar(int valor){
    //     if(valor > _valor){
    //         if(_HD == null)
    //             _HD = new Nodo(valor);
    //         else 
    //             _HD.Insertar(valor);
    //     }
    //     else if (valor < _valor){
    //         if(_HI == null)
    //             _HI = new Nodo(valor);
    //         else 
    //             _HI.Insertar(valor);
    //     }
    // }

    public void Insertar(int valor){
        _HD = (_HD == null && valor>_valor)?new Nodo(valor):_HD;
        if (valor > _valor && _HD != null) _HD.Insertar(valor);

        _HI = (_HI == null && valor<_valor)?new Nodo(valor):_HI;
        if (valor < _valor && _HI != null) _HI.Insertar(valor);
    }

    // public ArrayList GetInorden(){
    //     ArrayList l = new ArrayList();
    //     if(_HI != null)
    //         l = _HI.GetInorden();
        
    //     l.Add(_valor);
        
    //     if(_HD != null)
    //         l.AddRange(_HD.GetInorden());

    //     return l;     
    // }
    public ArrayList GetInorden(){
        ArrayList l = (_HI?.GetInorden() ?? new ArrayList());
        l.Add(_valor);
        if (_HD != null) l.AddRange(_HD.GetInorden());
        return l;
    }
    public int GetAltura() => Math.Max((_HD?.GetAltura() +1 ?? 0), (_HI?.GetAltura() +1 ?? 0) );
    // public int GetCantNodos(){
    //     int temp = 0;
    //     if (_HD != null)
    //         temp += _HD.GetCantNodos();
    //     if (_HI != null)
    //         temp +=_HI.GetCantNodos();
    //     temp++;

    //     return temp;
    // }
    public int GetCantNodos()=> (_HD?.GetCantNodos() ?? 0) + ((_HI?.GetCantNodos() ?? 0)) + 1;
    public int GetValorMaximo() => (_HD == null)? _valor:_HD.GetValorMaximo();
    public int GetValorMinimo() => (_HI == null)? _valor:_HI.GetValorMinimo();
}

//ej8
class Matriz
{

    private int _columnas;
    private int _filas;
    private double[,] _matriz;

    public Matriz(int f, int c)
    {
        _columnas = c;
        _filas = f;
        _matriz = new double[f, c];
    }
    public Matriz(double[,] mat)
    {
        _matriz = mat;
        _columnas = mat.GetLength(1);
        _filas = mat.GetLength(0);
    }

    public static Matriz operator +(Matriz m1, Matriz m2) => new Matriz(m1.sumaRetorno(m2));
    public void SetElemento(int fila, int columna, double elemento)
    {
        _matriz[fila, columna] = elemento;
    }

    public double GetElemento(int fila, int columna) => _matriz[fila, columna];

    public void Imprimir()
    {
        for (int i = 0; i < _columnas; i++)
        {
            for (int j = 0; j < _filas; j++)
            {
                Write(_matriz[i, j]);
            }
            WriteLine("");
        }
    }

    public void Imprimir(string formatString)
    {

        for (int j = 0; j < _columnas; j++)
        {
            for (int i = 0; i < _filas; i++)
            {
                Write($"{_matriz[j,i].ToString(formatString)} ");
            }
            WriteLine();
        }
    }

    public double[] GetFila(int fila)
    {
        double[] res = new double[1];
        for (var i = 0; i < _columnas; i++)
        {
            res[i] = _matriz[fila, i];
        }
        return res;
    }
    public double[] GetColumna(int columna)
    {
        double[] res = new double[1];
        for (var i = 0; i < _filas; i++)
        {
            res[i] = _matriz[i, columna];
        }
        return res;
    }
    public double[] GetDiagonalPrincipal()
    {
        if (_filas != _columnas)
            throw new ArgumentException("matriz no cuadrada");

        double[] res = new double[_filas];
        for (int i = 0; i < _filas; i++)
        {
            res[i] = _matriz[i, i];
        }
        return res;
    }

    public double[] GetDiagonalSecundaria()
    {
        if (_filas != _columnas)
            throw new ArgumentException("matriz no cuadrada");

        double[] res = new double[_filas];
        for (int i = 0; i < _filas; i++)
        {
            res[i] = _matriz[i, _columnas - i];
        }
        return res;
    }
    public double[][] getArregloDeArreglo()
    {
        double[][] res = new double[_filas][];
        for (int i = 0; i < _columnas; i++)
        {
            res[i] = new double[_columnas];
            for (int j = 0; j < _filas; j++)
            {
                res[i][j] = _matriz[i, j];
            }
        }
        return res;
    }

    public void sumarle(Matriz m)
    {
        for (int i = 0; i < _filas; i++)
        {
            for (int j = 0; j < _columnas; j++)
            {
                SetElemento(i, j, m.GetElemento(i, j) + _matriz[i, j]);
            }
        }
    }

    private double[,] sumaRetorno(Matriz m)
    {
        for (int i = 0; i < _filas; i++)
        {
            for (int j = 0; j < _columnas; j++)
            {
                SetElemento(i, j, m.GetElemento(i, j) + _matriz[i, j]);
            }
        }
        return _matriz;
    }
    public void restarle(Matriz m)
    {
        for (int i = 0; i < _filas; i++)
        {
            for (int j = 0; j < _columnas; j++)
            {
                _matriz[i, j] -= m.GetElemento(i, j);
            }
        }
    }
    public void multiplicarPor(Matriz m)
    {
        if (_columnas != m._filas)
            throw new ArgumentException("matriz no cuadrada");

        double[,] temp = new double[_filas, m._columnas];

        for (int i = 0; i < _filas; i++)
        {

            for (int k = 0; k < _filas; k++)
            {
                for (int j = 0; j < _columnas; j++)
                {
                    temp[i, k] += _matriz[i, j] * m.GetElemento(j, k);
                }
            }
        }
    }
}
