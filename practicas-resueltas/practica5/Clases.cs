namespace practica5;
using static System.Console;
public class Cuenta
{
    static int s_id=0; 
    static int s_depositos = 0;
    static int s_extracciones = 0;
    static int s_total_dep = 0;
    static int s_total_extr = 0;
    static int s_total_extr_fallidas = 0;
    static int s_saldo = 0;
    static List<Cuenta> s_lista = new List<Cuenta>();
    int _saldo=0;
    int _cuenta;
    public Cuenta(){
        _cuenta=++s_id;
        WriteLine($"Se creo la cuenta Id={_cuenta}"); 
        s_lista.Add(this);
        }
    public Cuenta Depositar(int monto){
        _saldo+=monto;
        WriteLine($"Se depositó {monto} en la cuenta {_cuenta} (Saldo={_saldo})");
        s_depositos++;
        s_saldo +=monto;
        s_total_dep+=monto;
        return this;
    }

    public Cuenta Extraer(int monto){
        if(_saldo-monto>=0){
            _saldo-=monto;
            WriteLine($"Se extrajo {monto} en la cuenta {_cuenta} (Saldo={_saldo})");
            s_extracciones++;
            s_saldo -=monto;
            s_total_extr+=monto;
        }
        else {
            WriteLine("Operación denegada - Saldo insuficiente");
            s_total_extr_fallidas++;
        }
        return this;
    }

    public static void ImprimirDetalle(){
        WriteLine($"CUENTAS CREADAS: {s_id}");
        Write($"DEPOSITOS: {s_depositos,-11}- "); WriteLine($"Total depositado {s_total_dep,5}");
        Write($"EXTRACCIONES: {s_extracciones,-8}- "); WriteLine($"Total extraido {s_total_extr,7}");
        Write($"{" ",-21} - ");  WriteLine($"Saldo: {s_saldo,13}");
        WriteLine($" * Se denegaron {s_total_extr_fallidas} extracciones por falta de fondos");
    }
    //ej2
    /*public static List<Cuenta> GetCuentas(){
        return new List<Cuenta>(s_lista);
    }*/

    //ej3
        public static List<Cuenta> GetCuentas{
            get => new List<Cuenta>(s_lista);
        }
}

class Persona{
    public int Edad{get;}
    public string Nombre {get; set;}

    public char Sexo {get; set;}
    public static int Idx = 0;

    public int Dni {get; set;}

    public DateTime FechaNacimiento {get; set;}

    public object? this[int i]{
        get{
            switch (i)
            {
                case 0: return this.Nombre;
                case 1: return this.Sexo; 
                case 2: return this.Dni;
                case 3: return FechaNacimiento;
                case 4: return Edad;
                default:
                    return null;
            }
        }
        set{
            switch (i)
            {
                case 0: this.Nombre=value.ToString(); break;
                case 1:  this.Sexo=(char)value; break;
                case 2:  this.Dni=(int)value; break;
                case 3:  FechaNacimiento=(DateTime)value; break;
            }
        }
    }
}

class ListaDePersonas
{
    List<Persona> lista = new List<Persona>();
    public void Agregar(Persona p)
    {
        lista.Add(p);
    }

    public Persona? this[int i]{
        get{
            foreach (Persona p in lista)
            {
                if(p.Dni == i) return p;
            }
            return null;
        }
    }
    public List<String> this[char c]{
        get{
            List<String> aux = new List<string>();
            foreach (Persona p in lista)
            {
                if(p.Nombre[0] == c) aux.Add(p.Nombre);
            }
            return aux;
        }
    }

}

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

    public double this[int f, int c]{
        get => _matriz[f,c];
        set=> _matriz[f,c] = value;
        }
    public void Imprimir()
    {
        for (int i = 0; i < _columnas; i++)
        {
            for (int j = 0; j < _filas; j++)
            {
                Write(this[i, j]);
            }
            WriteLine("");
        }
    }

    public double[] DiagonalPrincipal{
        get{
            if (_filas != _columnas)
                throw new ArgumentException("matriz no cuadrada");

            double[] res = new double[_filas];
            for (int i = 0; i < _filas; i++)
            {
                res[i] = this[i, i];
            }
            return res;
        }
    }

    public double[] DiagonalSecundaria{
        get{
            if (_filas != _columnas)
                throw new ArgumentException("matriz no cuadrada");

            double[] res = new double[_filas];
            for (int i = 0; i < _filas; i++)
            {
                res[i] = this[i, _columnas - i];
            }
            return res;
        }
    }

}
