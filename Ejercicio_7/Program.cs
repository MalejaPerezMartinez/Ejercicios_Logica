using System;
using System.Transactions;

internal class Program
{
    public static void Main(string[] args)
    {
        //Escribir un algoritmo que dados 2 valores de entrada imprima siempre la división del mayor entre el menor. Validar indeterminación.
        // Declarar variables

        double n1, n2, cociente;

        // Solicitar datos
        Console.Write("Ingrese el primer numero:");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese el segundo numero:");
        n2 = Convert.ToDouble(Console.ReadLine());


        // Condiciones

        if ((n1 == 0) || (n2 == 0))
        {
            Console.Write("La operación es Indeterminada");

        }

        else if ((n1 > n2))


        {
            cociente = n1 / n2;
            Console.Write("El resultado es" + " " + cociente);
        }

        else
        {
            cociente= n2 / n1;
            Console.Write("El resultado es" + " " + cociente);

        }

    }
}

    
