internal class Program
{
    public static void Main(string[] args)
    {
        //Construir un programa que pida un número y luego diga si este número es par o no.
        double n1;
        // Solicitar el numero 
        Console.Write("Ingrese un numero : ");
        // Convertir numero
        n1=Convert.ToDouble(Console.ReadLine());
        // Validaciones

        if(n1 == 0)
        {
            Console.Write("Es par");

        }

        else 
        if (((n1/n1))==1)
        {
            Console.Write("Es par");
        }
         else
        {
            Console.Write("Es impar");
        }

    }
}