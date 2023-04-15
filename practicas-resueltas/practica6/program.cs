using practica6;

using static System.Console;

//ej1
/*A[] vector = new A[] { new A(3), new B(5), new C(15), new D(41) };
foreach (A a in vector)
{
    a.Imprimir();
}*/

//ej2
/*A[] vector = new A[] { new C(1), new D(2), new B(3), new D(4), new B(5) };
//a
foreach (A a in vector)
{
    if((a is B) && (a is not C) && (a is not D)){
        a.Imprimir();
    }
}
//b
foreach (A a in vector)
{
    if(a.GetType()==typeof(B)){
        a.Imprimir();
    }
}*/

//ej3
//el campo de auto es privada por lo que no puede ser modificada por otra clase.
// Para que esto funcione se podria hacer que velocidad sea protected

//ej4
//no hace falta poner el :base porque por defecto llama al constructor vacio de base


//ej5
//el problema es que _dueño1 y _dueño 2 son privadas por lo que no se puede devolver estas personas 
//en un metodo con mas accesibilidad que privado, ademas que Persona es de tipo internal por lo que
//_dueño1 y 2 tampoco pueden ser mas accesibles que esto

//ej6
/*
1) pone override en B pero el metodo en A no se declaro como virtual
2) solo una clase abstracta puede tener metodos abstractos
3) un metodo abstracto no puede tener cuerpo
4) una clase que no es heredada no puede poner override
5) no se puede cambiar el modificador de acceso de un metodo heredado
6) un miembro estatico no se puede marcar cni como virtual ni override
7) los miembros privados no pueden ser virtuales
8) ningun constructor en B llama a un constructor de A
(el constructor vacio de A no esta porque hicimos otro constructor)
9) no puedo acceder a un campo privado de una clase padre
10) el get tiene que ser mas restrictivo que la propiedad
11) la propiedad de A no esta autoimplementada porque esta marcada como abstract,
por lo que falta declarar el set en B
12) B esta intentando invalidar un metodo valido de A
*/

//ej7
//Imprimidor.Imprimir(new A(), new B(), new C(), new D());

//ej8
/*
Empleado[] empleados = new Empleado[] {
new Administrativo("Ana", 20000000, DateTime.Parse("26/4/2018"), 10000) {Premio=1000},
new Vendedor("Diego", 30000000, DateTime.Parse("2/4/2010"), 10000) {Comision=2000},
new Vendedor("Luis", 33333333, DateTime.Parse("30/12/2011"), 10000) {Comision=2000}
};
foreach (Empleado e in empleados)
{
    Console.WriteLine(e);
    e.AumentarSalario();
    Console.WriteLine(e);
}*/