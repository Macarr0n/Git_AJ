using System.ComponentModel.Design;
using System.Linq.Expressions;
using Listas;

namespace Plantilla;

class Program
{
    static string[] ops = { "Quit", "InsertaPpi", "InsertaPos", "PosElto", "CuentaEltos", "InsertUlt", "BorraPrimElto", "Suma", "CuentaOcurrencias", "Nesimo", "InsertaNesimo", "BorraTodos" };
    static void Main(string[] args)
    {
        Lista l = new Lista();
        l.InsertaPri(3);
        l.InsertaPri(7);
        l.InsertaPri(8);
        l.InsertaPri(5);
        l.InsertaPri(6);
        l.InsertaPri(8);
        l.InsertaPri(4);
        l.InsertaPri(9);
        l.InsertaPri(1);

        Console.WriteLine($"List: {l}");
        bool cont = true;
        while (cont)
        {
            int op = Menu(ops);
            if (op == 0) cont = false;
            else Test(op, l);
        }

    }

    static void Test(int op, Lista l)
    {
        if (ops[op] == "InsertaPpi")
        {
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            l.InsertaPri(e);
        }
        else if (ops[op] == "InsertaPos")
        {
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            Console.Write("Pos ");
            int pos = int.Parse(Console.ReadLine());
            l.InsertaPos(e, pos);
        }
        else if (ops[op] == "PosElto")
        {
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            int pos = l.PosElto(e);
            Console.WriteLine($"Pos de {e}: {pos}");
        }
        else if (ops[op] == "CuentaEltos")
        {
            Console.WriteLine("Elementos de la lista: " + l.CuentaEltos());
        }
        else if (ops[op] == "InsertUlt")
        {
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            l.InsertUlt(e);
        }
        else if (ops[op] == "BorraPrimElto")
        {
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            l.BorraPrimElto(e);
        }
        else if (ops[op] == "Suma")
        {
            Console.WriteLine("La suma de los elementos de la lista es: " + l.Suma());
        }
        else if (ops[op] == "CuentaOcurrencias")
        {
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("El elemento aparece " + l.CuentaOcurrencias(e) + " veces");
        }
        else if (ops[op] == "Nesimo")
        {
            Console.Write("Posición ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("El elemento aparece que está en la posición " + n + " es " + l.Nesimo(n));
        }
        else if (ops[op] == "InsertaNesimo")
        {
            Console.Write("Posición ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Elem ");
            int e = int.Parse(Console.ReadLine());
            l.InsertaNesimo(n,e);
        }
        else if (ops[op] == "BorraTodos")
        {
            Console.Write("Elem ");
            int n = int.Parse(Console.ReadLine());
            l.BorraTodos(n);
        }




        Console.WriteLine($"List: {l}");
    }

    static int Menu(string[] ops)
    {
        Console.WriteLine("\nOption: ");
        int op;
        do
        {
            for (int i = 0; i < ops.Length; i++)
                Console.WriteLine($"{i}. {ops[i]}");
            op = int.Parse(Console.ReadLine());
        } while (op < 0 || op > ops.Length);
        return op;
    }

}