namespace C_;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao sistema.");

        //Entrada de dados
        Console.WriteLine("Digite seu nome: ");
        string nome = Console.ReadLine();

        //Para receber informa;'oes diferente de string [e preciso converter]
        Console.WriteLine("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nOla, {nome}! Voce tem {idade} anos.");

        //Como colocar if else
        if (idade < 18)
        {
            Console.WriteLine("Voce ainda e menor de idade");
        }
        else
        {
            Console.WriteLine("Voce ja e maior de idade");
        }

        //Menu
        Console.WriteLine("\nEscolha uma opcao: ");
        Console.WriteLine("1 - ver a tabuada de um numero");
        Console.WriteLine("2 - contar ate um numero");
        Console.WriteLine("3 - Sequencia de Fibonacci");
        Console.WriteLine("4 - sair");
        Console.WriteLine("digite sua opcao");
        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("\nDigite o numero desejado: ");
                int num = int.Parse(Console.ReadLine());
                for (var i = 1; i < 11; i++)
                {
                    int resposta;
                    resposta = num * i;
                    Console.WriteLine(num + " x " + i + " = " + resposta);
                }
                break;

            case 2:
                Console.WriteLine("\nDigite ate qual numero voce quer contar: ");
                int count = int.Parse(Console.ReadLine());
                for (var i = 1; i <= count; i++)
                {
                    Console.Write(i + " - ");
                }
                break;

            case 3:

                Console.WriteLine("Digite numero de termos da sequencia: ");
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    Console.WriteLine("O número de termos deve ser positivo.");
                }

                int anterior = 0;
                int atual = 1;
                int proximo;

                for (int i = 1; i < n; i++)
                {
                    if (i == 0)
                    {
                        Console.Write(anterior + " ");
                        continue;
                    }
                    if (i == 1)
                    {
                        Console.Write(atual + " ");
                        continue;
                    }

                    proximo = anterior + atual;
                    Console.Write(proximo + " ");

                    anterior = atual;
                    atual = proximo;
                }
                break;

            case 4:
                Console.Write("Obrigada pela visita em nosso sistema!");
                break;
        }
    }
}
