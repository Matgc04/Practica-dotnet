using System.Collections;
using static System.Console;
using practica8;

//Declarar los tipos delegados necesarios para que el siguiente programa compile y produzca la
//salida en la consola indicada
/*Del1 d1 = delegate (int x) { Console.WriteLine(x); };
d1(10);
Del2 d2 = x => Console.WriteLine(x.Length);
d2(new int[] { 2, 4, 6, 8 });
Del3 d3 = x =>
{
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        sum += i;
    }
    return sum;
};
int resultado = d3(10);
Console.WriteLine(resultado);
Del4 d4 = new Del4(LongitudPar);
Console.WriteLine(d4("hola mundo"));
bool LongitudPar(string st)
{
    return st.Length % 2 == 0;
}
*/

//ej2
/*Del1 d1 = delegate (int x) { Console.WriteLine(x); };
d1(10);
Del2 d2 = x => Console.WriteLine(x.Length);
d2(new int[] { 2, 4, 6, 8 });
Del3 d3 = x =>
{
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        sum += i;
    }
    return sum;
};
int resultado = d3(10);
Console.WriteLine(resultado);
Del4 d4 = new Del4(LongitudPar);
Console.WriteLine(d4("hola mundo"));
bool LongitudPar(string st)
{
    return st.Length % 2 == 0;
}
*/
/*
2) ¿Qué obtiene un método anónimo (o expresión lambda) cuando accede a una variable definida en
el entorno que lo rodea, una copia del valor de la variable o la referencia a dicha variable?
Rta:una referencia a la variable
*/

//ej3
/*3) Teniendo en cuenta lo respondido en el ejercicio anterior, ¿Qué salida produce en la consola la
ejecución del siguiente programa?
10,10,10,10... 10 veces
*/
/*Action[] acciones = new Action[10];
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i + " ");
    acciones[i] = () => Console.WriteLine(i + " ");
}

foreach (var a in acciones)
{
    a.Invoke();
}
*/

//ej4
/*
int[] vector = new int[] { 1, 2, 3, 4, 5 };
vector.Print("Valores iniciales: ");
var vector2 = vector.Seleccionar(n => n * 3);
vector2.Print("Valores triplicados: ");
vector.Seleccionar(n => n * n).Print("Cuadrados: ");
*/
//ej5
/*
int[] vector = new int[] { 1, 2, 3, 4, 5 };
vector.Print("Valores iniciales: ");
vector.Donde(n => n % 2 == 0).Print("Pares: ");
vector.Donde(n => n % 2 == 1).Seleccionar(n => n * n).Print("Impares al cuadrado: ");
*/