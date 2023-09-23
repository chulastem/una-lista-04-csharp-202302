namespace lista4;
public class Exercicio3
{
    public static void exercicio()
    {
        var nome = (String?)null;
        var sexo = (String?)null;
        var escv = (String?)null;
        int idade;
        double salario;

        do
        {
            Console.WriteLine("Digite seu nome: (maior que 3 caracteres) ");
            nome = Convert.ToString(Console.ReadLine());
            if (nome?.Length < 3)
            {
                Console.WriteLine("Nome invalido!");
            }
        } while (nome?.Length < 3);

        do
        {
            Console.WriteLine("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 0 || idade > 150)
            {
                Console.WriteLine("Idade invalida");
            }
        } while (idade < 0 || idade > 150);

        do
        {
            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());
            if (salario < 0)
            {
                Console.WriteLine("Salário invalido!");
            }
        } while (salario < 0);

        do
        {
            Console.WriteLine("Digite seu Sexo (M ou F): ");
            sexo = Convert.ToString(Console.ReadLine());
            if (sexo != "m" && sexo != "f")
            {
                Console.WriteLine("Sexo invalido!");
            }
        } while (sexo != "m" && sexo != "f");

        do
        {
            Console.WriteLine("Digite seu Estado Civil (S, C, V ou D): ");
            escv = Convert.ToString(Console.ReadLine());
            if (escv != "c" && escv != "s" && escv != "v" && escv != "d")
            {
                Console.WriteLine("Estado Civil invalido!");
            }
        } while (escv != "c" && escv != "s" && escv != "v" && escv != "d");

        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Idade: {idade}");
        Console.WriteLine($"Salário: R${salario}");
        Console.WriteLine($"Sexo: {sexo}");
        Console.WriteLine($"Estado Civil: {escv}");
        Console.ReadLine();
    }
}
