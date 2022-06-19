namespace _05_AreaRetangulo
{
    public class Program
    {
        static void Main(string [] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Calcule a área de um retangulo");
            Console.Write("Digite a altura: ");
            retangulo.Altura = int.Parse(Console.ReadLine() + "");
            Console.Write("Digite a base: ");
            retangulo.Base = int.Parse(Console.ReadLine() + "");
            retangulo.ExibirDados();


        }
    }
}
