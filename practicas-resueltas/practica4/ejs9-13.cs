//ej9
/*Foo f = new Foo();
f.Imprimir();
class Foo
{
string? _bar;
public void Imprimir()
{
Console.WriteLine(_bar.Length);
}
}
*/
//en este caso _bar se inicializa en null, da un warning de q _bar puede ser null

/*Foo f = new Foo();
f.Imprimir();
class Foo
{
public void Imprimir()
{
string? _bar;
Console.WriteLine(_bar.Length);
}
}*/
//ademas del warning, da un error porque la variable no esta declarada


//ej10
/*class A
{
public void Metodo(short n)
{
Console.Write("short {0} - ", n);
}
public void Metodo(int n)
{
Console.Write("int {0} - ", n);
}
public int Metodo(int n)
{
return n + 10;
}
}*/
//no podes tener 2 metodos que solo difieran en el parametro de retorno (el 2do y el 3er metodo)

//ej11
/*object o = 5;
Sobrecarga s = new Sobrecarga();
s.Procesar(o, o);
s.Procesar((dynamic)o, o);
s.Procesar((dynamic)o, (dynamic)o);
s.Procesar(o, (dynamic)o);
s.Procesar(5, 5);
class Sobrecarga
{
    public void Procesar(int i, object o)
    {
        Console.WriteLine($"entero: {i} objeto:{o}");
    }
    public void Procesar(dynamic d1, dynamic d2)
    {
        Console.WriteLine($"dynamic d1: {d1} dynamic d2:{d2}");
    }
}
*/
//entero objeto, entero objeto, dynamic dynamic, entero objeto, entero objeto
//el posta: dynamic dynamic, entero objeto, entero objeto, dynamic dynamic, entero objeto

//ej12
/*class Cuenta
{
    private double _monto = 0;
    private int? _titularDNI;
    private string? _titularNombre;

    public Cuenta(){}

    public Cuenta(string nombre){
        _titularNombre = nombre;
    }
    public Cuenta(int dni){
        _titularDNI = dni;
    }

    public Cuenta(string nombre, int dni) :this(nombre){
        _titularDNI = dni;
    }

    public void Imprimir(){
        string st = "No especificado";
        string st2 = this._titularDNI != null ? this._titularDNI.ToString() : st;
        Console.WriteLine($"Nombre: {this._titularNombre ?? st}, DNI: {st2}, Monto: {this._monto}");
    }

    public void Depositar(int num){
        _monto += num;
    }

    public void Extraer(int num){
        if(num <= _monto)
            //_monto -= num;
            Depositar(-num);
        else 
            Console.WriteLine("Operacion cancelada, monto insuficiente");
    }
}
*/

//ej13
/*Reemplazar estas líneas de código por otras equivalentes que utilicen el operador null-coalescing (?? ) y / o
la asignación null-coalescing (??=)*/
/*if (st1 == null)  
{
    if (st2 == null)
    {
        st = st3;
    }
    else
    {
        st = st2;
    }
}
else
{
    st = st1;
}*/
//Todo lo anterior se puede resumir con st = st1 ?? (st2 ?? st3);

/*if (st4 == null)
{
    st4 = "valor por defecto";
}*/
//esto se puede reemplazar por st4 ??= "valor por defecto";