namespace lista4;
public class Exercicio5
{
    public static void exercicio()
    {
        Console.WriteLine("Números ímpares entre 1 e 50:");

        for (int i = 1; i <= 50; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadLine();
    }
}