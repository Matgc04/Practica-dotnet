// using System;
// //ej21
// int i = 1;
// if (--i == 0)
// {
//     Console.WriteLine("cero");
// }
// if (i++ == 0)
// {
//     Console.WriteLine("cero");
// }
// Console.WriteLine(i);
// //ej20
// /*el problema es que estas declarando dos veces la misma variable, para solucionarlo borra el primer i o el segundo*/
// for (int i20 = 1; i20 <= 10;)
// {
//     Console.WriteLine(i20++);
// }

//ej19
//lineas invalidas
//int a = 2; b = 3; c = 4; no vale porque usas ; y no usas int
//int a = 2, int b = 3, int c = 4; no vale porque usas , y dsps clavas un int
//int a; int c = a; no pudes usar una variable no asignada
//11. char c = 'A', string st = "Hola"; clavas una coma en vez de ;
//char c = 'A', st = "Hola"; char usa '' no ""

//ej18
/*<1
uno
dos
tres
> 3*/
// for (int i = 0; i <= 4; i++)
// {
// string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
// Console.WriteLine(st);
// }

//ej17
/*
int c = a<b ? a : b;
*/

//ej16
//como el & evalua ambos terminos cuando b=0 va a dar error. Para arreglar esto hay que usar &&
//if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);

//ej15
// int anio = int.Parse(Console.ReadLine());
// string ans = (anio % 4==0 && anio % 100!=0) ? "si" : (anio %100==0 && anio %400==0) ? "si" : "no";
// Console.WriteLine(ans);

//ej14
// string num = (365 * int.Parse(Console.ReadLine())).ToString();
// for (int i = num.Length-1; i >=0; i--)
// {
//     Console.Write(num[i] + " ");
// }

//ej13
// double d = double.Parse(Console.ReadLine()) + double.Parse(Console.ReadLine());
// Console.WriteLine(d);

//ej12
// int num = int.Parse(Console.ReadLine());

// for (int i = 2; i <= Math.Abs(num) / 2; i++)
// {
//     if (num%i==0) Console.WriteLine(i.ToString() + "\n" + (-i).ToString()); 
// }

//ej11
//el / divide 
// transforma el numero en un string y lo appendea al string

//ej10
// for (int i = 1; i < 1001; i++)
// {
//     if (i%17==0 || i%29==0) Console.WriteLine(i);
// }

//ej9
// string st = Console.ReadLine();
// int j = st.Length -1, i = 0;

// while(i<j & st[i]==st[j]){
//     i++; j--;
// }
// if (i<j) Console.WriteLine("no");
// else
//     Console.WriteLine("si");

//ej8
//si

//ej7
//escribe 3

//ej 6
// string st = Console.ReadLine();
// while(st!=""){
//     Console.WriteLine(st.Length);
//     st = Console.ReadLine();
// }

//ej4
// string st;
// Console.WriteLine("pone tu nombre ");
// st = Console.ReadLine();
// if (st=="") Console.WriteLine("Hola Mundo");
// else 
//     Console.WriteLine("Hola " + st);

//ej5 
// string st;
// Console.WriteLine("pone tu nombre ");
// st = Console.ReadLine();

// if (st=="") Console.WriteLine("Buen dia Mundo");
// else if (st== "Juan")
//     Console.WriteLine("Hola amigo");
// else if (st== "Maria")
//     Console.WriteLine("Buen dia seniora");
// else if (st== "Alberto")
//     Console.WriteLine("Hola " + st);
// else 
//     Console.WriteLine("Buen dia " + st);

// switch(st){
//     case "":
//         Console.WriteLine("Buen dia Mundo");
//         break;
//     case "Juan":
//         Console.WriteLine("Hola amigo");
//         break;
//     case "Maria":
//         Console.WriteLine("Buen dia seniora");
//         break;
//     case "Alberto":
//         Console.WriteLine("Hola " + st);
//         break;
//     default:
//         Console.WriteLine("buen dia " + st);
//         break;   
    //}

//ej3
// string st = "c:\\windows\\system";
// Console.WriteLine(st);

//ej2
// \n hace newline, \t hace tabulacion horizontal, \\ es para escribir una barra inversa normalita, \ lo usas para usar secuencias de escape
// mas secuencias de escape: https://www.nachocabanes.com/csharp/curso/csharp02c.php

//ej1
//writeLine es lo mismo que write, ambos escriben en terminal, pero agrega un salto de linea.
//ReadKey lee un solo caracter el cual muestra en pantalla a no ser que lo inhabilites poniendole true adentro
