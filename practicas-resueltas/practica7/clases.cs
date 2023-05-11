namespace practica7;
using static System.Console;

//ej1 al 6
interface IAlquilable{
    void SeAlquilaA(Persona p);

    void DevueltoPor(Persona p);

}

interface IAtendible{
    void Atender();
}

interface IComercial{
    void Importa();
}

interface IImportante{
    void Importa();
}

interface ILavable{
    void Lavar();
    void Secar();

}

interface INombrable{
    string Nombre {get; set;}

    //string ToString();
}

interface IReciclable{
    void Reciclar();
}

interface IVendible{
    void Vender(IVendible vendible, Persona p);
}



class Auto : ILavable, IReciclable, IVendible, IComercial, IImportante
{
    public void Lavar() => WriteLine($"Lavando {this}");

    public void Secar() => WriteLine($"Secando {this}");

    public void Reciclar() => WriteLine($"Reciclando {this}");

    public void Vender(IVendible vendible, Persona p) => WriteLine($"Vendiendo {this} a {p}");

    void IImportante.Importa(){
        WriteLine("Auto importante");
    }

    void IComercial.Importa(){
        WriteLine("Auto que se vende al exterior");
    }

    public void Importa(){
        WriteLine("Metodo Importar() de la clase Auto");
    }
}

class ComparadorLongitudNombre : System.Collections.IComparer
{
    public int Compare(object? x, object? y)
    {
        if(x is INombrable p1 && y is INombrable p2){
            //INombrable p1 = (INombrable)x;
            //INombrable p2 = (INombrable)y;
            return p1.Nombre.Length.CompareTo(p2.Nombre.Length);
        }
        return 0;
    }
}
class Libro : IAlquilable, IReciclable
{
    public void SeAlquilaA(Persona p) => WriteLine($"Alquilando {this} a {p}");

    public void DevueltoPor(Persona p) => WriteLine($"{this} devuelto por {p}");

    public void Reciclar() => WriteLine($"Reciclando {this}");
}

class Pelicula : IAlquilable
{
    public virtual void SeAlquilaA(Persona p) => WriteLine($"Alquilando {this} a {p}");

    public virtual void DevueltoPor(Persona p) => WriteLine($"{this} devuelta por {p}");
}

class PeliculaClasica : Pelicula, IVendible
{
    public void Vender(IVendible vendible, Persona p) => WriteLine($"Vendiendo pelicula clasica a {p}");

    public override void SeAlquilaA(Persona p) => WriteLine($"Alquilando pelicula clasica a {p}");

    public override void DevueltoPor(Persona p) => WriteLine($"Pelicula clasica devuelta por {p}");
}

class Perro : IAtendible, IVendible, ILavable, INombrable, IComparable
{
    /*public int CompareTo(object? obj){
        if(obj is INombrable){
            INombrable p = (INombrable)obj;
            return this.Nombre.CompareTo(p.Nombre);
        }
        return 0;
    }*/
    public int CompareTo(object? obj){
        if(obj is Perro p){
            return this.Nombre.CompareTo(p.Nombre);
        }
        else if (obj is Persona) return 1;
        return 0;

        //return (obj is Perro p) ?  this.Nombre.CompareTo(p.Nombre) : (obj is Persona) ? 1 :0;  //mas corto menos legible
    }
    public void Atender() => WriteLine($"Atendiendo {this}");

    public void Lavar() => WriteLine($"Lavando {this}");

    public void Secar() => WriteLine($"Secando {this}");

    public void Vender(IVendible vendible, Persona p) => WriteLine($"Vendiendo {this} a {p}");

    public string Nombre {get; set;}="";

    public override string ToString(){
        return "es un perro";
    }
}

class Persona: IAtendible, IComercial, IImportante, INombrable, IComparable
{
    public void Atender() => WriteLine($"Atendiendo {this}");

    void IImportante.Importa(){
        WriteLine("Persona importante");
    }

    void IComercial.Importa(){
        WriteLine("Persona vendiendo al exterior");
    }

    public void Importa(){
        WriteLine("Metodo Importar() de la clase Persona");
    }

    public string Nombre {get; set;}="";

    public override string ToString(){
        return "es una persona";
    }

    public int CompareTo(object? obj){
        if(obj is INombrable p){
            return this.Nombre.CompareTo(p.Nombre);
        }
        return 0;
    }
}




static class Procesador
{
public static void Alquilar(IAlquilable alquilable, Persona p) => alquilable.SeAlquilaA(p);

public static void Atender(IAtendible alquilable) => alquilable.Atender();

public static void Devolver(IAlquilable alquilable, Persona p) => alquilable.DevueltoPor(p);

public static void Lavar(ILavable lavable) => lavable.Lavar();

public static void Secar(ILavable lavable) => lavable.Secar();


public static void Reciclar(IReciclable reciclable) => reciclable.Reciclar();

public static void Vender(IVendible vendible, Persona p) => vendible.Vender(vendible, p);

}

//ej10

public class Auto{
    public string Marca {get; set;}
    public string Modelo {get; set;}
}
