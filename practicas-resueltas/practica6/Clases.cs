namespace practica6;
using static System.Console;

//ej1 y 2
// class A
//     {
//     protected int _id;
//     public A(int id) => _id = id;
//     public virtual void Imprimir() => Console.WriteLine($"A_{_id}");
//     }

//     class B : A
//     {
//         public B(int id): base(id){}
//         public override void Imprimir()
//     {
//         Write($"B_{_id} --> ");
//         base.Imprimir();
//     }
//     }
//     class C : B
//     {
//         public C(int id): base(id){}
//         public override void Imprimir()
//     {
//         Write($"C_{_id} --> ");
//         base.Imprimir();
//     }
//     }
//     class D : C
//     {
//         public D(int id): base(id){}
//     public override void Imprimir()
//     {
//         Write($"D_{_id} --> ");
//         base.Imprimir();
//     }
// }

//ej3
/*class Auto
{
double velocidad;
public virtual void Acelerar()
=> Console.WriteLine("Velocidad = {0}", velocidad += 10);
}
class Taxi : Auto
{
public override void Acelerar()
=> Console.WriteLine("Velocidad = {0}", velocidad += 5);
}*/

//ej4
/*
class Auto
{
    public string Marca { get; private set; } = "Ford";
    public Auto(string marca) => this.Marca = marca;

}
class Taxi : Auto
{
    public int Pasajeros { get; private set; }
    public Taxi(int pasajeros): base("Ford")=> this.Pasajeros = pasajeros;
}*/

//ej7
/*
class A {
    public void ImprimirA() => Console.WriteLine("Soy una instancia A");
}
class B {
    public void ImprimirB() => Console.WriteLine("Soy una instancia B");
}
class C {
    public void ImprimirC() => Console.WriteLine("Soy una instancia C");
}
class D {
    public void ImprimirD() => Console.WriteLine("Soy una instancia D");
}

/*static class Imprimidor {
    // public static void Imprimir(params object[] vector) {
    //     foreach (object o in vector) {
    //         if (o is A) { (o as A)?.ImprimirA(); }
    //         else if (o is B) { (o as B)?.ImprimirB(); }
    //         else if (o is C) { (o as C)?.ImprimirC(); }
    //         else if (o is D) { (o as D)?.ImprimirD(); }
    //     }
    // }

    //solucion no polimorfica pero que acorta las lineas
    public static void Imprimir(params object[] vector) {
        foreach (object o in vector) {
            if (o is A a) a?.ImprimirA(); 
            else if (o is B b) b?.ImprimirB(); 
            else if (o is C c) c?.ImprimirC(); 
            else if (o is D d) d?.ImprimirD(); 
        }
    }
}*/

/*
class Letra{
    protected string id;
    public void Imprimir() => WriteLine($"Soy una instancia {this.GetType().ToString().Split(".")[1]}");
}
class A : Letra{
}
class B: Letra{
}
class C : Letra{
}
class D : Letra{
}
static class Imprimidor {
    public static void Imprimir(params object[] vector) {
        foreach (Letra letra in vector) {
            letra.Imprimir();
        }
    }
}*/

//ej8
/*8) Crear un programa para gestionar empleados en una empresa. Los empleados deben tener las
propiedades públicas de sólo lectura Nombre, DNI, FechaDeIngreso, SalarioBase y Salario. Los
valores de estas propiedades (a excepción de Salario que es una propiedad calculada) deben
establecerse por medio de un constructor adecuado.
Existen dos tipos de empleados: Administrativo y Vendedor. No se podrán crear objetos de la
clase padre Empleado, pero sí de sus clases hijas (Administrativo y Vendedor). Aparte de las
propiedades de solo lectura mencionadas, el administrativo tiene otra propiedad pública de
lectura/escritura llamada Premio y el vendedor tiene otra propiedad pública de lectura/escritura
llamada Comision.
La propiedad de solo lectura Salario, se calcula como el salario base más la comisión o el premio
según corresponda.
Las clases tendrán además un método público llamado AumentarSalario() que tendrá una
implementación distinta en cada clase. En el caso del administrativo se incrementará el salario base
en un 1% por cada año de antigüedad que posea en la empresa, en el caso del vendedor se
incrementará el salario base en un 5% si su antigüedad es inferior a 10 años o en un 10% en caso
contrario.*/

/*
abstract class Empleado{
    public string Nombre{get;}
    public int DNI{get;}
    public int SalarioBase{get; protected set;}
    public abstract int Salario{get;}
    public DateTime FechaDeIngreso{get;}
    public Empleado(string nombre, int dni, int salarioBase, DateTime fechaDeIngreso){
        Nombre = nombre;
        DNI = dni;
        SalarioBase = salarioBase;
        FechaDeIngreso = fechaDeIngreso;
    }
    public abstract void AumentarSalario();

    public override string ToString() =>
     $"{this.GetType().ToString().Split(".")[1]} Nombre: {Nombre}, DNI: {DNI} Antiguedad: {DateTime.Now.Year - FechaDeIngreso.Year}\n Salario Base: {SalarioBase} Salario: {Salario} \n ----------------------------";

}
class Administrativo : Empleado{
    public int Premio{get; set;}
    public override int Salario{get{return SalarioBase + Premio;}}
    public Administrativo(string nombre, int dni, DateTime fechaDeIngreso, int salarioBase) :base(nombre, dni, salarioBase, fechaDeIngreso){}
    public override void AumentarSalario(){
        int antiguedad = DateTime.Now.Year - FechaDeIngreso.Year;
        SalarioBase += (int)(SalarioBase * 0.01 * antiguedad);
        //Salario = SalarioBase + this.Premio;
    }
}

class Vendedor : Empleado{
    public int Comision{get; set;}
    public override int Salario{get{return SalarioBase + Comision;}}
    public Vendedor(string nombre, int dni, DateTime fechaDeIngreso, int salarioBase) :  base(nombre, dni, salarioBase, fechaDeIngreso){}
    public override void AumentarSalario(){
        int antiguedad = DateTime.Now.Year - FechaDeIngreso.Year;
        if(antiguedad < 10) SalarioBase += (int)(SalarioBase * 0.05);
        else SalarioBase += (int)(SalarioBase * 0.1);
        //Salario = SalarioBase + Comision;
    }

}
*/