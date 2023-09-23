namespace lista4;
public class Exercicio1
{
    public static void exercicio()
    {
        double n = 0;
        do
        {
            Console.WriteLine("Digite uma nota de 0 a 10: ");
            n = Convert.ToDouble(Console.ReadLine());
            if (n < 0 || n > 10)
            {
                Console.WriteLine("Nota invalida!");
            }
        } while (n < 0 || n > 10);
        Console.WriteLine("OK");
        Console.ReadLine();
    }

}

