using static System.Console;
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

