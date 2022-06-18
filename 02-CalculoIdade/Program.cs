namespace _02_CalculoIdade
{
    public class Program
    {
        static void Main(string []args)
        {
            Console.WriteLine("Programa que calcula a idade de uma pessoa");
            Pessoa pessoa = new Pessoa();
            Console.Write("Digite o nome: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Digite o ano de nascimento: ");
            pessoa.anoNascimento = int.Parse(Console.ReadLine());
            pessoa.ExibirDados();

            
        }
    }
}
