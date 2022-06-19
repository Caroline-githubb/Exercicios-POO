namespace _04_ExercicioMaiorIdade
{
    public class Program
    {
        static void Main(string [] args)
        {
            Pessoa p1,p2,p3;
            Console.WriteLine("Determina qual pessoa é a mais veha");
            Console.Write("Nome da Pessoa 1: ");
            p1 = new Pessoa();
            p1.Nome = Console.ReadLine() + "";
            Console.Write("Idade da Pessoa 1: ");
            p1.Idade = int.Parse(Console.ReadLine() + "");

            Console.Write("Nome da Pessoa 2: ");
            p2 = new Pessoa();
            p2.Nome = Console.ReadLine() + "";
            Console.Write("Idade da Pessoa 2: ");
            p2.Idade = int.Parse(Console.ReadLine() + "");

            Console.Write("Nome da Pessoa 3: ");
            string nome = Console.ReadLine() + "";
            Console.Write("Idade da Pessoa : ");
            int idade = int.Parse(Console.ReadLine() + "");
            p3 = new Pessoa(nome, idade);

            if ((p1.Idade > p2.Idade) && (p1.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p1.ExibirDados();
            }

            else if ((p2.Idade > p1.Idade) && (p2.Idade > p3.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p2.ExibirDados();
            }

            else if ((p3.Idade > p1.Idade) && (p3.Idade > p2.Idade))
            {
                Console.WriteLine("A pessoa mais velha é: ");
                p3.ExibirDados();
            }
            
            else
            {
                Console.WriteLine("Todos tem a mesma idade!");
            }      
             

            

        }
    }
    
}
