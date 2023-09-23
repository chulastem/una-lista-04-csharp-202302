namespace lista4;
public class Exercicio6
{
    public static void exercicio()
    {
        int n1, n2;
        Console.WriteLine("Digite o primeiro número: ");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        if (n1 < n2)
        {
            for (int i = n1; i <= n2; i++)
            {
                Console.WriteLine(i);
            }
        }
        if (n2 < n1)
        {
            for (int i = n2; i <= n1; i++)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();
    }

}