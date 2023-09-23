namespace lista4;
public class Exercicio2
{
    public static void exercicio()
    {
        var nome = (String?)null; var senha = (String?)null;
        do
        {
            Console.WriteLine("Digite seu nome de usuario: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a sua senha: ");
            senha = Convert.ToString(Console.ReadLine());
            if (nome == senha)
            {
                Console.WriteLine("Nome e senha iguais!!");
            }
        } while (nome == senha);
        Console.WriteLine("Acesso ok.");
        Console.ReadLine();
    }
}