using static System.Console;

//ej1
// Console.CursorVisible = false;
// ConsoleKeyInfo k = Console.ReadKey(true);
// while (k.Key != ConsoleKey.End)
// {
// Console.Clear();
// Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
// k = Console.ReadKey(true);
// }

//ej2
// void ImprimirMatriz(double[,] matriz){
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         for (int i = 0; i < matriz.GetLength(0); i++)
//         {
//             Write($"{matriz[j,i]} ");
//         }
//         WriteLine();
//     }
// }

// double[,] m1 = { { 1, 2,3}, { 3, 4,3}, {1,2,1} };
// ImprimirMatriz(m1);

//ej3
// void ImprimirMatrizConFormato(double[,] matriz, string formatString){
//     for (int j = 0; j < matriz.GetLength(1); j++)
//     {
//         for (int i = 0; i < matriz.GetLength(0); i++)
//         {
//             Write($"{matriz[j,i].ToString(formatString)} ");
//         }
//         WriteLine();
//     }
// }

// double[,] m1 = { { 1, 2,3}, { 3, 4,3}, {1,2,1} };
// ImprimirMatrizConFormato(m1, "0.0");

//ej4
// double[] GetDiagonalPrincipal(double[,] matriz){
//     if(matriz.GetLength(0) != matriz.GetLength(1))
//         throw new ArgumentException("matriz no cuadrada");

//     double[] res = new double[matriz.GetLength(1)];

//     for (int i = 0; i < matriz.GetLength(0); i++)
//     {
//         res[i] = matriz[i,i];
//     }
//     return res;
// }

// double[] GetDiagonalSecundaria(double[,] matriz){
//     int cont = matriz.GetLength(0);
//     if(cont != matriz.GetLength(1))
//         throw new ArgumentException("error");

//     double[] res = new double[cont];
    
//     cont--;
//     for (int i = 0; i < matriz.GetLength(1); i++)
//     {
//         res[i] = matriz[i,cont];
//         cont--;
//     }

//     return res;
// }

// double[,] m1 = { { 1, 2,3}, { 3, 4,3}, {1,2,1} };
// double[] m2 = GetDiagonalSecundaria(m1);

// foreach (var item in m2)
// {
//         WriteLine(item);
// }

//ej5
// double[][] GetArregloDeArreglo(double [,] matriz){
//     double[][] res = new double[matriz.GetLength(0)][];
//     for (int i = 0; i < matriz.GetLength(0); i++)
//     {
//         res[i] = new double[matriz.GetLength(1)];
//         for (int j = 0; j < matriz.GetLength(1); j++)
//         {
//             res[i][j] = matriz[i,j];
//         }
//     }
//     return res;
// }

// double[,] m1 = { { 1, 2}, { 3, 4} };
// double[][] m2 = GetArregloDeArreglo(m1);

// foreach (var item in m2)
// {
//     foreach (var item2 in item)
//     {
//         WriteLine(item2);
//     }
    
// }


//ej6
// double[,]? Suma(double[,] A, double[,] B){
//     if(A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
//         return null;
//     for (int i = 0; i < A.GetLength(0); i++)
//     {
//         for (int j = 0; j < A.GetLength(1); j++)
//         {
//             A[i,j] += B[i,j];
//         }
//     }
//     return A;
// }

// double[,]? Resta(double[,] A, double[,] B){
//     if(A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
//         return null;
//     for (int i = 0; i < A.GetLength(0); i++)
//     {
//         for (int j = 0; j < A.GetLength(1); j++)
//         {
//             A[i,j] -= B[i,j];
//         }
//     }
//     return A;
// }

// double[,] Multiplicacion(double[,] A, double[,] B){
//     if(A.GetLength(1) != B.GetLength(0))
//         throw new ArgumentException("error");

//     double[,] temp = new double[A.GetLength(0),B.GetLength(1)];

//     for(int i = 0; i < A.GetLength(0); i++){

//         for (int k = 0; k < A.GetLength(0); k++)
//         {
//             for (int j = 0; j < A.GetLength(1); j++)
//             {
//                 temp[i,k] += A[i,j] *B[j,k];
//             }
//         }
//     }
//     return temp;
// }

// double[,] m1 = { { 1, 2}, { 3, 4}, };
// double[,] m2 = { { 1, 2 } };

// double[,] A= new double[2,2];
// A = Multiplicacion(m1, m2) ;

// foreach (var item in A)
// {
//     WriteLine(item);
// }



//ej7
// int i = 10;//int32
// var x = i * 1.0; //double
// var y = 1f; //single ==float
// var z = i * y; //single
// WriteLine(i.GetType());

//ej8
// var a = 3L;
// dynamic b = 32;
// object obj = 3;
// //a = a * 2.0; no se puede conVertir double a long
// b = b * 2.0;
// b = "hola";
// obj = b;
// b = b + 11;
// //obj = obj + 11; no se puede usar el + con obj e int
// var c = new { Nombre = "Juan" };
// var d = new { Nombre = "María" };
// var e = new { Nombre = "Maria", Edad = 20 };
// var f = new { Edad = 20, Nombre = "Maria" };
// //f.Edad = 22; f es de solo lectura
// d = c;
// e = d; //no se puede transformar de un anonymous type a otro
// f = e; //no se puede transformar de un anonymous type a otro


//ej9
/*error en tiempo de compilacion: obj no tiene una propiedad length, error en tiempo de ejecucion: int no tiene una propiedad length*/
// object obj = new int[10];
// dynamic dyn = 13;
// Console.WriteLine(obj.Length);
// Console.WriteLine(dyn.Length);

//ej10
//WriteLine($"{2.333333335567899999:0.00000000}");//redondea
//WriteLine(2.33333333556666668.ToString("0.00000000")); //redondea

//ej11
//el unico error es el RemoveAt porq no da el indice, el remove no da error simplemente devuelve false
// List<int> a = new List<int>() { 1, 2, 3, 4 };
// a.Remove(5);
// a.RemoveAt(4);

//ej12 no se banca caracteres que no esten en el alfabeto
// Queue<int> cifrado(string mensaje, int[] clave){
//     Queue<int> mensCifrado = new Queue<int>();
//     Queue<int> numsMensaje = new Queue<int>();
//     for (int i = 0; i < mensaje.Length; i++)
//     {
//         if (i<clave.Length)
//             mensCifrado.Enqueue(clave[i]);
//         else 
//             mensCifrado.Enqueue(clave[i%clave.Length]);

//         if (char.ToUpper(mensaje[i]) == ' ')
//             numsMensaje.Enqueue(28);
//         else if (char.ToUpper(mensaje[i])=='Ñ') numsMensaje.Enqueue(15);
//         else if (char.ToUpper(mensaje[i])>='O'){
//             //WriteLine(char.ToUpper(mensaje[i])-63);
//             numsMensaje.Enqueue(char.ToUpper(mensaje[i])-63); //hay que tener en cuenta la enie,  O-63 = 16
//         }
//         else {
//             //WriteLine(char.ToUpper(mensaje[i])-64);
//             numsMensaje.Enqueue(char.ToUpper(mensaje[i])-64);
//         }
//     }

//     for (int i = 0; i < mensCifrado.Count; i++)
//     {   
//         int num = mensCifrado.Dequeue();
//         if (numsMensaje.Peek()==28) 
//             mensCifrado.Enqueue((num));
//         else {
//             int numCifrado = numsMensaje.Peek() + num;
//             if (numCifrado<=28)
//                 mensCifrado.Enqueue(numCifrado);
//             else 
//                 mensCifrado.Enqueue(numCifrado%28);
//         }
//         numsMensaje.Dequeue();
//     }
//     return mensCifrado;
// }

// string descifrado(Queue<int> msjCifrado, int[] clave){
//     for (int i = 0; i < msjCifrado.Count; i++)
//     {   
//         int numSinClave;
//         if (i<clave.Length)
//             numSinClave = msjCifrado.Dequeue()-clave[i];
//         else 
//             numSinClave = msjCifrado.Dequeue()-clave[i%clave.Length];
//         numSinClave = (numSinClave<=0) ? numSinClave+28: numSinClave;
//         //WriteLine(numSinClave);
//         msjCifrado.Enqueue(numSinClave);
//     }

//     char[] letras = new char[msjCifrado.Count];
//     int vueltas = msjCifrado.Count;
//     for (int i = 0; i < vueltas; i++)
//     {
//         int numActual = msjCifrado.Dequeue();
//         if (numActual == 28)
//             letras[i] = ' ';
//         else if (numActual == 15) 
//             letras[i]='Ñ';
//         else if (numActual+63>=79) 
//             letras[i] = (char) (numActual+63); 
//         else 
//             letras[i] = (char) (numActual+64);
//     }
//     string st= new String(letras);
//     return st;
// }

// int [] clave = {5,3,9,7};
// Queue <int> msjCifrado = cifrado("HOLA MUNDO", clave);
// // foreach (var item in msjCifrado)
// // {
// //     WriteLine(item);
// // }

// WriteLine();
// WriteLine(descifrado(msjCifrado, clave));

//ej13
// WriteLine("ingrese una expresion aritmetica, te digo si los parentesis estan bien");
// string st = ReadLine();
// bool mal = false;
// Stack<char> pila = new Stack<char>();
// foreach(char item in st){
//     if(item == '('){
//         pila.Push(item);
//     }
//     else if (item == ')' && pila.Count > 0) 
//             pila.Pop();
//     else if ((item == ')' && pila.Count == 0)){
//         mal = true;
//         break;
//     }
// }
// WriteLine(pila.Count);
// if (pila.Count == 0 && !mal) 
//     WriteLine("expresion correcta") ;
// else
//     WriteLine("expresion incorrecta");

//ej14
//nota: esta implementacion funciona solo para enteros y esta bastante fea
// Stack<int> pila = new Stack<int>();
// WriteLine("ingrese base a la que va a convertir");
// int divisor = int.Parse(ReadLine());
// WriteLine("ingrese num que va a convertir");
// int num = int.Parse(ReadLine());
// int resto;

// int idx = (int)Math.Ceiling(Math.Log(num, divisor));
// for (int i = 0; i < idx; i++)
// {
//     resto =num%divisor;
//     WriteLine($"el numero actual es {num}, el divisor es {divisor}");
//     WriteLine($"el resto es de {resto}");
//     num = num/divisor;
//     ReadLine();
//     pila.Push(resto);
// }

// do {
//     resto =num%divisor;
//     WriteLine($"el numero actual es {num}, el divisor es {divisor}");
//     WriteLine($"el resto es de {resto}");
//     num = num/divisor;
//     ReadLine();
//     pila.Push(resto);
// }
// while(num>=divisor);

// pila.Push(num%divisor);

// foreach (var item in pila)
// {
//     WriteLine(item);
// }

//ej15
/*el programa va a escribir el simbolo de infinito y despues va a dar una excepcion.
La division por cero da error si son 2 enteros pero si hay un numero en punto flotante involucrado va a dar infinito*/

// int x = 0;
// try
// {
// Console.WriteLine(1.0 / x);
// Console.WriteLine(1 / x);
// Console.WriteLine("todo OK");
// }
// catch (Exception e)
// {
// Console.WriteLine(e.Message);
// }

//ej16
// WriteLine("ingrese un numero o no ponga nada para finalizar");
// string st = ReadLine();
// double contador =0;
// while (st!=""){
//     try{
//         double num = double.Parse(st);
//         contador += num;
//         WriteLine($"la suma acumulada es de {contador}");
//     }
//     catch(FormatException){
//         WriteLine("pone un numero o nada flaco");
//     }
//     finally{
//         WriteLine("proximo numero: ");
//         st = ReadLine();
//     }
// }

//ej 17
// try{
//     WriteLine("ingrese numero 1");
//     double num1 = double.Parse(ReadLine());
//     WriteLine("ingrese numero 2");
//     double num2 = double.Parse(ReadLine());

//     WriteLine("ingrese operador. Puede ser un *, /, +, -");
//     string operador = ReadLine();
//     checked{ //creo que este no esta haciendo nada
//         switch (operador) {
//             case "*":
//                 WriteLine(num1*num2);
//                 break;
//             case "/":
//                     double res = num1/num2;
//                     if (Double.IsInfinity(res)) throw new DivideByZeroException("dividiste por zero");
//                     WriteLine(res);
//                     break;
//             case "+":
//                 WriteLine(num1+num2);
//                 break;
//             case "-":
//                 WriteLine(num1-num2);
//                 break;
//         }
//     }
// }
// catch (FormatException){
//     WriteLine("tenes que poner un numero");
// }
// catch(DivideByZeroException){
//     WriteLine("division por 0");
// }
// catch (OverflowException){
//     WriteLine("overfloww");
// }
// catch (Exception e){
//     WriteLine($"otro error {e}");
// }

//ej 18
// va a ejecutar el finally dentro del metodo1, y afuera va a ser catcheado, en el metodo2 va a ser catcheado afuera,
// y en el 3 va a ser catcheado dentro del metodo pero por el throw se catchea afuera
// void Metodo1(){
// object obj = "hola";
//     try{
//         int i = (int)obj;
//     }
//     finally{
//         Console.WriteLine("Bloque finally en Metodo1");
//     }
// }
// void Metodo2(){
// object obj = "hola";
//     try{
//         int i = (int)obj;
//     }
//     catch (OverflowException){
//         Console.WriteLine("Overflow");
//     }
// }
// void Metodo3(){
//     object obj = "hola";
//     try{
//         int i = (int)obj;
//     }
//     catch (InvalidCastException){
//         Console.WriteLine("Excepción InvalidCast en Metodo3");
//         throw;
//     }
// }

// try{
//     Metodo1();
// }
// catch{
//     Console.WriteLine("Método 1 propagó una excepción no tratada");
// }
// try{
//     Metodo2();
// }
// catch{
//     Console.WriteLine("Método 2 propagó una excepción no tratada");
// }
// try{
//     Metodo3();
// }
// catch{
//     Console.WriteLine("Método 3 propagó una excepción");
// }
