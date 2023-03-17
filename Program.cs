using static System.Console;
using System.Text;
using System.Diagnostics;
//ej7
//c = ""; las comillas dobles representan un string
//c = null; c no es nullable
//c2 = (65 as char?); no es un error de compilacion pero le das siempre null
//st = '' usando lineas de char con strings
// st = null; //no es incorrecto pero tira warning
// st = (char)65; no se puede pasar char a st
//string st = (string)65; se usa el .ToString()
//ej8
// for(int i=0; i < args.Length; i++){
//     WriteLine("Hola " + args[i] + "!");
// }
// foreach (var arg in args)
// {
//     WriteLine("Hola con foreach " + arg + "!");
//}

//ej9
/*es preferible usar StringBuilder cuando queres 
agregar cosas, ya que el string normal es inmutable 
y el stringBuilder no. Al agregar texto a un string,
se crea un nuevo objeto string en la heap y se
abandona el string anterior para ser recogido por 
el gc*/
// aca es mejor pero no tan mejor
// Stopwatch stopwatch = Stopwatch.StartNew();
// string st = new String('c', 900_000_0);
// foreach (var letter in st)
// {
//     int j = letter;
// }
// stopwatch.Stop(); // Detener la medición.
// Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));

// Stopwatch stopwatch2 = Stopwatch.StartNew();
// StringBuilder stb = new StringBuilder('x', 990000000);
// for (int i = 0; i < stb.Length; i++)
// {
//     int j = stb[i];
// }
// stopwatch2.Stop(); // Detener la medición.
// Console.WriteLine("Time elapsed: {0}", stopwatch2.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));

//ej15
//metodo recursivo zz
// int Fib(int n){
//     if(n<2) return 1;
//     return Fib(n-1) + Fib(n-2);
// }
// WriteLine(Fib(30));

//implementar metodos no recursivo


//ej16
// int Fac(int n){
//     int temp = n;
//     if (n == 0) return 1;
//     for (int i = n - 1; i >= 2 ; i--)
//     {
//         temp *= i;
//     }
//     return temp;
// }
// int FacRecu(int n){
//     if (n==1 || n==0) return 1;
//     return n*FacRecu(n-1);
// }

// int FacRecuTer(int n) => (n==1 || n==0) ? 1 : n *FacRecuTer(n-1);
// WriteLine(Fac(0));
// WriteLine(FacRecu(4));
// WriteLine(FacRecuTer(4));

//ej17
//ejercicio para el lector

//ej18
// void Swap(ref int a, ref int b){
//     a= a ^ b;
//     b = a ^ b;
//     a = a ^b;
//}
// int a=5, b=4;
// WriteLine("a y b precambio " + a.ToString() + " " + b.ToString());
// Swap(ref a, ref b);
// WriteLine("a y b postcambio " + a.ToString() + " " + b.ToString());


//ej19
// void Imprimir(params object[] objetos){
//     for (int i = 0; i < objetos.Length; i++)
//     {
//         Write(objetos[i] + " ");
//     }
//     WriteLine(" ");
// }
// Imprimir(1, "casa", 'A', 3.4, DayOfWeek.Saturday);
// Imprimir(1, 2, "tres");
// Imprimir();
// Imprimir("-------------");

