internal class Program
{
    private static void Main(string[] args)
    {
       
        //Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con dichos números. Mostrar en pantalla un mensaje de advertencia que indique que el segundo número debe ser diferente de 0. Imprimir en pantalla el resultado de cada operación.

        // Se declaran las variables
        int n1, n2;
        double multi, divi, sum, rest;

        // leer se usa write.line
        Console.WriteLine("Ingrese numero 1");
        
        n1= Convert.ToInt32(Console.ReadLine());// con la opcion de convert asigo loque se ingreso por consola y lo convierto en numero 

        Console.WriteLine("Ingrese numero 2, debe ser mayor a cero");
        n2= Convert.ToInt32(Console.ReadLine());

        // Calculos

        sum= n1 + n2;
        rest= n2 - n1;
        multi= n1*n2;
        divi= n1/n2;

        // imprimir en pantalla
        Console.WriteLine("Suma: " + n1+" + " + n2+" = "+sum);
        Console.WriteLine("Resta:" + n1 + " - " + n2 + " = " + rest);
        Console.WriteLine("Multiplicacion:" + n1 + " - " + n2 + " = " + multi);
      


    }
}