using static System.Console;
namespace practica8;

delegate void Del1(int x);
delegate void Del2(int[] x);
delegate int Del3(int x);
delegate bool Del4(string st);

//ej4

delegate int FuncionEntera (int x);
static class VectorDeEnterosExtension
{
    public static void Print(this int[] vector, string leyenda)
    {
        string st = leyenda;
        if (vector.Length > 0)
        {
            foreach (int n in vector) st += n + ", ";
            st = st.Substring(0, st.Length - 2);//resto para sacar el , de mas
        }
        Console.WriteLine(st);
    }

    public static int[] Seleccionar(this int[] vector, FuncionEntera f)
    {
       int[] vector2 = new int[vector.Length];
       for (int i = 0; i < vector2.Length; i++)
       {
           vector2[i] = f(vector[i]);
       }
       return vector2;
    }

    //ej5
    public static int[] Donde(this int[] vector, Predicado f){
        //int[] vector2 = new int[vector.Length];
        List<int> lista = new List<int>();
        for (int i = 0; i < vector.Length; i++)
        {
            if(f(vector[i]))
                lista.Add(vector[i]);
        }
        return lista.ToArray();
    }
}

delegate bool Predicado(int n);