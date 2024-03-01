internal class Program
{
    public static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor, el del medio y el menor de los números ingresados.
        double n1, n2, n3;

        // solicitar números
        Console.Write("Ingrese primer numero: ");
        n1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese segundo numero: ");
        n2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese tercer numero: ");
        n3 = Convert.ToDouble(Console.ReadLine());

        // Validar condiciones

        if (((n1 > n2) && (n2 > n3)))
        {
            Console.Write("El orden es:" + n1 + "," + n2 + "," + n3);
        }
        else if (((n1 > n3) && (n3 > n2)))
        {
            Console.Write("El orden es: " + n1 + "," + n3 + "," + n2);
        }
        else if (((n2 > n1) && (n1 > n3)))
        {
            Console.Write("El orden es: " + n2 + "," + n1 + "," + n3);
        }
        else if (((n2 > n3) && (n3 > n1)))
        {
            Console.Write("El orden es: " + n2 + "," + n3 + "," + n1);
        }
        else if (((n3 > n1) && (n1 > n2)))
        {
            Console.Write("El orden es: " + n3 + "," + n1 + "," + n2);
        }
        else 
        { 
            Console.Write("El orden es: " + n3 + "," + n2 + "," + n1); 
        }
    }
}
