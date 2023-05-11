using static System.Console;
using System.Text;
using System.Diagnostics;
//ej1
// char c1 = 'A'; //declaracion simple
// string st1 = "A"; // declaraccion simple
// object o1 = c1; //boxing
// object o2 = st1; // en teoria aca no hay boxing porque string ya es tipo referencia
// char c2 = (char)o1; //unboxing
// string st2 = (string)o2; // aca no hay unboxing

//ej2
//esto es porque al asignarle "Z" al objeto2 se crea un nuevo objeto al cual ahora objeto2 apunta
// object o1 = "A";
// object o2 = o1;
// WriteLine(o2==o1);
// o2 = "Z";
// WriteLine(o2==o1);
// WriteLine(o1 + " " + o2);

//ej3
//el while no va con ;, eso hace que se ejecute infinitamente (lo que no me queda claro es que se estaria ejecutando, la comparacion del while?)

//ej4
// Console.WriteLine(args == null); false
// Console.WriteLine(args.Length); 0

//ej5
// aca se crea un objeto vacio, al cual vector apunta. como es int[]? tambien se podria apuntar a null, pero no lo esta haciendo
// int[]? vector = new int[0]; 
// WriteLine(vector.Length);

//ej6
//index out of range exception, la variable args no tiene objetos por lo que al intentar acceder a la posicion 0 hay un error (NO es nula)
// Console.WriteLine("¡Hola {0}!", args[0]); 

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

//ej10
//usé stopWatch aca, no DateTime

//ej11
/*el metodo split crea una matriz de subcadenas dividiendo la cadena en base a los delimitadores elegidos*/
// string st ="";
// for (int i = 0; i < args.Length; i++)
// {
//     st = st +" " + args[i];
// }
// Console.WriteLine(st);
// string[] ans = st.Split(' ');

// foreach (var word in ans)
// {
//     Console.WriteLine(word);
// }

//ej12
//...

//for(Meses m=Meses.Diciembre; m>= Meses.Enero; m--){
//     WriteLine(m);
// }
// //ej13b
// WriteLine("ingrese un mes del año y te digo si esta en la lista");
// string st = ReadLine();
// for(Meses m=Meses.Diciembre; m>= Meses.Enero; m--){
//     if(m.ToString()==st) {
//         WriteLine("mes valido");
//         break;
//     }
//     if(m==Meses.Enero) WriteLine("no hay un mes asi");
// }
// enum Meses
// {
//     Enero, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
// }

//ej14
// bool esPrimo(int n){
//     for (int i = 2; i < Math.Sqrt(n); i++)
//     {
//         if(n%i!=0)
//             continue;
//         return false;
//     }
//     return true;
// }
// WriteLine(esPrimo(int.Parse(args[0])));

//ej15
//fib(0)=1
// int FibRec(int n){
//     if(n<2) return 1;
//     return Fib(n-1) + Fib(n-2);
// }
// WriteLine(FibRec(30));

//mas eficiente
// int FibRec2(int n, int i=1, int j=1){
//     if(n<2)
//         return j;
//     int temp=i;
//     i=j;
//     j+=temp;
//     /*si lo queres hacer sin el acumulador
//     i^=j; j^=i; i^=j; j+=i;
//     o
//     i^=j; j^=i; j+=i^=j;
//     */
//     return Fib(n-1,i,j);
// }

//metodo no recursivo
// int FibIter(int n){
//     if(n<2) return 1;
//     int act=1, ant=0, aux=1;
//     for (int i = 1; i < n; i++)
//     {
//         ant=aux;
//         aux=act;
//         act += ant;
//     }
//     return act;
// }
// WriteLine(Fib(14));

//ej16
// int Fac(int n){
//     int temp = n;
//     if (n == 0) return 1;
//     for (int i = n - 1; i >= 2 ; temp*=i--);
//     return temp;
// }
// int FacRecu(int n){
//     if (n==1 || n==0) return 1;
//     return n*FacRecu(n-1);
// }
// int FacCorto(int n){
//     int temp=1;
//     for(int i=2; i<=n; temp*=i++);
//     return temp;
// }
// int FacRecuTer(int n) => (n<2) ? 1 : n *FacRecuTer(n-1);
// WriteLine(Fac(0));
// WriteLine(FacRecu(4));
// WriteLine(FacRecuTer(4));

//ej17
//ejercicio para el lector

//ej18
// void SwapXor(ref int a, ref int b){
//     a ^=b;
//     b ^=a;
//     a ^=b;
//}
// void SwapSuma(ref int x, ref int y){
//     x +=y;
//     y = x-y;
//     x -=y;
// }
// void SwapNormal(ref int a, ref int b){
//     int temp=a;
//     a=b;
//     b=temp;
// }
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