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
        Console.WriteLine("3 - sair");
        Console.WriteLine("digite sua opcao");
        int opcao = int.Parse(Console.ReadLine());
    }
}
