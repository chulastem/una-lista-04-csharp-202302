namespace lista4;
public class Exercicio4
{
    public static void exercicio()
    {
        int n = 5;
        double soma = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Informe o número " + i + ": ");
            double numero = Convert.ToDouble(Console.ReadLine());
            soma += numero;
        }

        double media = soma / n;

        Console.WriteLine($"\nSoma dos números: {soma}");
        Console.WriteLine($"Média dos números: {media}");
        Console.ReadLine();
    }
}