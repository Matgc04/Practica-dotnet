using practica4;
using System.Collections;
using static System.Console;

//ej 2 y 3
// string[]? input;
// ArrayList listaP = new ArrayList();
// WriteLine("Ingrese 'Nombre,edad,dni<enter>' solo presione enter para terminar");
// input = ReadLine().Split(',');
// while (input[0]!="")
// {
//     listaP.Add(new Persona(input[0], int.Parse(input[1]),  int.Parse(input[2]) ));
//     WriteLine("Ingrese 'Nombre,edad,dni<enter>' solo presione enter para terminar");
//     input = ReadLine().Split(',');
// }

// foreach (Persona item in listaP)
// {
//     item.Imprimir();
// }

// Persona? aux = null;
// if(listaP.Count>0)
//     aux = (Persona)listaP[0];
// for (int i = 1; i < listaP.Count; i++)
// {   
//     Persona actual = (Persona)listaP[i];
//     if (!aux.EsMayorQue(actual))
//         aux = actual;
// }
// WriteLine("");
// if(aux!=null)
//     aux.Imprimir();
// else
//     WriteLine("lista vacia");

//ej4 y 5
// Hora h = new Hora(23,30,15);
// h.Imprimir();
// new Hora(14.43).Imprimir();
// new Hora(14.45).Imprimir();
// new Hora(14.45114).Imprimir();

//ej6
//new Ecuacion2(1,4,2).ImprimirRaices();

//ej7
// Nodo arbol = new Nodo(10);
// for (int i = 1; i < 2; i++)
// {
//     arbol.Insertar(10+i);
//     arbol.Insertar(10-i);
// }
// ArrayList lista = arbol.GetInorden();
// WriteLine(arbol.GetValorMaximo());
// WriteLine(arbol.GetValorMinimo());
// WriteLine(arbol.GetAltura());
// WriteLine(arbol.GetCantNodos());
// WriteLine(lista.Count);
// foreach (var item in lista)
// {
//     WriteLine(item);
// }

//ej8
// Matriz m1 = new Matriz(2, 2);
// double[,] dd = new double[2, 2];
// for (int i = 0; i < 2; i++)
// {
//     for (int j = 0; j < 2; j++)
//     {
//         if (i == j)
//             dd[i, j] = 1;
//         else
//             dd[i, j] = 0;
//     }

// }
//Matriz m2 = new Matriz(dd);
//m1.Imprimir();
//m2.Imprimir();

//m2.multiplicarPor(m2);
//m2.Imprimir();
//(m2+m2).Imprimir();
