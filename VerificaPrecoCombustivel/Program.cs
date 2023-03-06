using System;

internal class Program
{
    private static void Main(string[] args)
    {
        double alcool, gasolina, price;

        Console.WriteLine(" Informe o preco da gasolina");
        gasolina = double.Parse(Console.ReadLine());

        Console.WriteLine(" Informe o preco da alcool");
        alcool = double.Parse(Console.ReadLine());

        price = alcool / gasolina;

        if( price <= 0.72){
            Console.WriteLine( " Use alcool" );
        }
        else
        {
            Console.WriteLine( " Use gasolina");
        }
    }

}