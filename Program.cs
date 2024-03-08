// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Double numero;

Console.Write("numero: ");
numero = Convert.ToDouble(Console.ReadLine());

if (numero %2 == 0)
{
    Console.WriteLine("El numero es par");
}
else
    Console.WriteLine("El numero es impar");