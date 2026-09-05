namespace Variaveis;
public class Program
{
    public static void Main()
    {
        int senha = 2004;
        Console.WriteLine("Seu Nome: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Olá "+ nome);
        Console.WriteLine("Qual Sua senha?");
        int tentativa = Convert.ToInt32(Console.ReadLine());
        if (tentativa == senha)
            Console.WriteLine("Passou");

    }
}