using System.Collections;
using static System.Console;
using practica7;

//ej1
//nota: para que el tostring sea correcto se deberia crear un archivo para cada clase
/*
Auto auto = new Auto();
Libro libro = new Libro();
Persona persona = new Persona();
Perro perro = new Perro();
Pelicula pelicula = new Pelicula();

Procesador.Alquilar(pelicula, persona);
Procesador.Alquilar(libro, persona);
Procesador.Atender(persona);
Procesador.Atender(perro);
Procesador.Devolver(pelicula, persona);
Procesador.Devolver(libro, persona);
Procesador.Lavar(auto);
Procesador.Reciclar(libro);
Procesador.Reciclar(auto);
Procesador.Secar(auto);
Procesador.Vender(auto, persona);
Procesador.Vender(perro, persona);
*/

//ej2
/*
Auto auto = new Auto();
Libro libro = new Libro();
Persona persona = new Persona();
Perro perro = new Perro();
Pelicula pelicula = new Pelicula();
Procesador.Alquilar(pelicula, persona);
Procesador.Alquilar(libro, persona);
Procesador.Atender(persona);
Procesador.Atender(perro);
Procesador.Devolver(pelicula, persona);
Procesador.Devolver(libro, persona);
Procesador.Lavar(auto);
Procesador.Reciclar(libro);
Procesador.Reciclar(auto);
Procesador.Secar(auto);
Procesador.Vender(auto, persona);
Procesador.Vender(perro, persona);
Procesador.Lavar(perro);
Procesador.Secar(perro);
PeliculaClasica peliculaClasica = new PeliculaClasica();
Procesador.Alquilar(peliculaClasica, persona);
Procesador.Devolver(peliculaClasica, persona);
Procesador.Vender(peliculaClasica, persona);*/

//ej3
/*var lista = new List<object>() { new Persona(), new Auto()};
foreach (IComercial c in lista)
{
    c.Importa();
}
foreach (IImportante i in lista)
{
    i.Importa();
}
(lista[0] as Persona)?.Importa();
(lista[1] as Auto)?.Importa();
*/

//ej4
/*var vector = new INombrable[] {
new Persona() {Nombre="Zulema"},
new Perro() {Nombre="Sultán"},
new Persona() {Nombre="Claudia"},
new Persona() {Nombre="Carlos"},
new Perro() {Nombre="Chopper"},
};
Array.Sort(vector); //debe ordenar por Nombre alfabéticamente
foreach (INombrable n in vector)
{
    Console.WriteLine($"{n.Nombre}: {n}");
}*/

//ej5
/*var vector = new INombrable[] {
new Persona() {Nombre="Zulema"},
new Perro() {Nombre="Sultán"},
new Persona() {Nombre="Claudia"},
new Persona() {Nombre="Carlos"},
new Perro() {Nombre="Chopper"},
};
Array.Sort(vector); //debe ordenar por Nombre alfabéticamente
foreach (INombrable n in vector)
{
    Console.WriteLine($"{n.Nombre}: {n}");
}*/

//ej6
/*var vector = new INombrable[] {
new Persona() {Nombre="Ana María"},
new Perro() {Nombre="Sultán"},
new Persona() {Nombre="Ana"},
new Persona() {Nombre="José Carlos"},
new Perro() {Nombre="Chopper"}
};
Array.Sort(vector, new ComparadorLongitudNombre());//ordena por longitud de Nombre
foreach (INombrable n in vector)
{
    Console.WriteLine($"{n.Nombre.Length}: {n.Nombre}");
}
*/

//ej7
/* Proponer una forma para conseguir un ordenamiento aleatorio de todos los elementos de un vector
de objetos (object[]) utilizando Array.Sort(). Cada vez que se invoque debe producir un
ordenamiento aleatorio diferente. */

/*object[] vector = { "Hola", 123, true};
Random rnd = new Random();
int[] keys = new int[vector.Length];
for (int i = 0; i < vector.Length; i++)
{
    keys[i] = rnd.Next();
}

// Ordenar el vector de objetos en base a los números aleatorios
Array.Sort(keys, vector);

foreach (object item in vector)
{
    WriteLine(item);
}
*/

//ej8
/*8) Codificar usando iteradores los métodos:
Rango(i, j, p) que devuelve la secuencia de enteros desde i hasta j con un paso de p
Potencia(b,k) que devuelve la secuencia b1,b2,....bk
DivisiblePor(e,i) retorna los elementos de e que son divisibles por i
*/
/*IEnumerable Rango(int i, int j, int p)
{
    for (int k = i; k <= j; k += p)
    {
        yield return k;
    }
}

IEnumerable Potencias(int b, int k)
{
    for (int i = 1; i <= k; i++)
    {
        yield return (int)Math.Pow(b, i);
    }
}


IEnumerable DivisiblesPor(IEnumerable e, int i)
{
    foreach (int item in e)
    {
        if (item % i == 0)
        {
            yield return item;
        }
    }
}
IEnumerable rango = Rango(6, 30, 3);
IEnumerable potencias = Potencias(2, 10);
IEnumerable divisibles = DivisiblesPor(rango, 6);
foreach (int i in rango)
{
Write(i + " ");
}
WriteLine();
foreach (int i in potencias)
{
Write(i + " ");
}
WriteLine();
foreach (int i in divisibles)
{
Write(i + " ");
}
WriteLine();
*/

//ej9
/*9) Codificar un programa que permita al usuario escribir un texto por consola. El mismo puede
constar de varios párrafos. Se considera el fin de la entrada cuando el usuario ingresa una línea vacía,
en ese momento el programa solicitará al usuario el nombre del archivo para guardar el texto escrito.
Si el usuario escribe un nombre de archivo válido, se guarda el texto ingresado en ese archivo, de lo
contrario no se hace nada y termina el programa.
a) Utilizando la instrucción using
b) Sin utilizar la instrucción using*/

/*List<string> input=new List<string>();
do
{
    WriteLine("Ingrese un texto vacio para terminar");
    input.Add(ReadLine()??"");
} while (input.Last() != "");

WriteLine("Ingrese el nombre del archivo");
string nombreArchivo = ReadLine()??"";

if (nombreArchivo.ToCharArray().Where( c => Path.GetInvalidFileNameChars().Contains(c) ).Count() > 0 || nombreArchivo == "")
{
    WriteLine("Nombre de archivo invalido");
}
else
{
    try
    {
        using (StreamWriter sw = new StreamWriter(nombreArchivo))
        //sw = new StreamWriter("destino.txt");
        {
            foreach (string item in input)
            {
                sw.WriteLine(item);
            }
        }
        
    }
    catch(Exception e)
    {
        WriteLine(e.Message);
    }
    
    //finally{
    //    sw?.Dispose();
    //}
    
    //Sin using va comentado
}
*/

