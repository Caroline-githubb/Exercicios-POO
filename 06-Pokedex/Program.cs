namespace _06_Pokedex
{
    public class Program
    {
        static void Main(string [] args)
        {
            /*Pokemon p = new Pokemon();
            p.Nome = "Bulbasaouro";
            p.Descricao = "O Bulbasauro é um pokemon tipo planta";
            p.ExibirDadosPokemon(); */

            Pokemon p = new Pokemon("Bulbasaouro","O Bulbasauro é um pokemon tipo planta");
            p.ExibirDadosPokemon(true);
            Console.ReadKey();

        }
    }
}
