# Lista de Exercícios IV: Estrutura de Repetição

## UC - Estrutura de dados e análise de algoritmos -Pratica

**Pedro Antônio Esteves Silva - RA: 622122907**

Considerações Iniciais:
Esta lista de exercício deve:

- Ser realizada em equipes de até 06 alunos.
- Ser entregue no prazo proposto.
- Todos os integrantes devem enviar a lista na plataforma.
- Ter os algoritmos pedidos escritos em linguagem C#(csharp) ou Java.
- Ter todos os algoritmos devidamente identados.

1 - Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem
caso o valor seja inválido e continue pedindo até que o usuário informe um valor
válido

```csharp
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
```

2 - Faça um programa que leia um nome de usuário e a sua senha e não aceite a
senha igual ao nome do usuário, mostrando uma mensagem de erro e voltando a
pedir as informações.

```csharp
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
```

3 - Faça um programa que leia e valide as seguintes informações:
Nome: maior que 3 caracteres;
Idade: entre 0 e 150;
Salário: maior que zero;
Sexo: 'f' ou 'm';
Estado Civil: 's', 'c', 'v', 'd';

```csharp
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
```

4 - Faça um programa que leia 5 números e informe a soma e a média dos números.

```csharp
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
```

5 - Faça um programa que imprima na tela apenas os números ímpares entre 1 e 50.

```csharp
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
```

6 - Faça um programa que receba dois números inteiros e gere os números inteiros
que estão no intervalo compreendido por eles.

```csharp
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
```

7 - Faça um programa que peça 10 números inteiros, calcule e mostre a quantidade
de números pares e a quantidade de números impares

```csharp
namespace lista4;
public class Exercicio7
{
    public static void exercicio()
    {
        int numerosPares = 0;
        int numerosImpares = 0;

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("Digite o " + i + "º número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                numerosPares++;
            }
            else
            {
                numerosImpares++;
            }
        }

        Console.WriteLine($"Quantidade de números pares: {numerosPares}");
        Console.WriteLine($"Quantidade de números ímpares: {numerosImpares}");
        Console.ReadLine();
    }

}
```