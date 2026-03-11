using System;

class Program
{
    static void Main()
    {
        
        double[] numeros = new double[10];
        Console.WriteLine("--- Localizador de Maior Número ---");

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o {i + 1}º número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        double maior = numeros[0];
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] > maior)
            {
                maior = numeros[i];
            }
        }

        Console.WriteLine($"O maior número digitado foi: {maior}"););
    }
}
