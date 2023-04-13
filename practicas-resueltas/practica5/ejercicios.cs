using practica5;
using System.Collections;
using static System.Console;
//ej 1,2,3
/*Cuenta c1 = new Cuenta();
c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
Cuenta c2 = new Cuenta();
c2.Depositar(200).Depositar(800);
new Cuenta().Depositar(20).Extraer(20);
c2.Extraer(1000).Extraer(1);
Console.WriteLine("\nDETALLE");
Cuenta.ImprimirDetalle();

new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.GetCuentas;
cuentas[0].Depositar(50);
cuentas.RemoveAt(0);
Console.WriteLine(cuentas.Count);
cuentas = Cuenta.GetCuentas;
Console.WriteLine(cuentas.Count);
cuentas[0].Extraer(30);
*/
//ej4
/*a) valido
b) valido
c) un constructor static no puede tomar parametros
d) valido
e) no se pueden modificar variables no estaticas en un constructor estatico.
Ademas en el constructor de instancia estas modificando la copia del parametro y no la variable de instancia

f)valido
g)valido, el compilador reemplaza en todos los lugares que aparece la constante por el valor
h)no se puede asignar un valor que se determina en tiempo de ejecucion a una constante
i)valido, una variable readonly se puede inicializar en el constructor y el metodo add no sobreescribe la variable
j)no se puede sobreescribir una variable readonly fuera de su inicializacion o de un constructor 
k)valido
l)no se puede usar un indizador con static (necesitas una instancia de la clase para usarlo)
*/

//ej5
/*en el metodo2: ClaseA no es el nombre correcto, sino A; como el metodo es estatico no puedo modificar la variable de instancia c, 
y no puedo modificar una variable estatica con una referencia de instancia
*/


//ej9
/*el problema esta en que en el set en vez de usar la variable privada usamos la publica, haciendo una llamada recursiva infinita a si misma*/

//ej10
/*class A
{
private static int a; //campo estatico privado l/e
private static readonly int b; //campo estatico privado solo escritura
A() { } //constructor de instancia privado vacio
public A(int i) : this() { } //constructor de instancia con un parametro que llama al constructor vacio
static A() => b = 2; //constructor estatico que inicializa b
int c; //campo privado de instancia l/e
public static void A1() => a = 1; //metodo estatico publico que inicializa a
public int A1(int a) => A.a + a; //metodo publico de instancia que retorna la var estatica a + el parametro del metodo
public static int A2; //campo estatico publico l/e
static int A3 => 3; //metodo estatico privado 
private int A4() => 4; // metodo de instancia privado
public int A5 { get => 5; } //propiedad publica de instancia solo lectura no autoimplementado
int A6 { set => c = value; } //propiedad privada de instancia solo escritura no autoimplementada
public int A7 { get; set; }//propiedad publica de instancia l/e autoimplementada
public int A8 { get; } = 8;//propiedad publica de instancia autoimplementada con inicializacion
public int this[int i] => i;//indizador publico (un indizador solo puede ser de instancia)
}*/

//ej11
/*el a) es una asignacion a la variable X con el valor 3
el b) es una funcion llamada X que retorna 3*/
