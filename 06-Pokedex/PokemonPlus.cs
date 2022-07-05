namespace _06_Pokedex
{
    public class PokemonPlus : Pokemon
    {
        public PokemonPlus():base()
        {
            this.Poder = 0;            
        }
        public PokemonPlus(string nome, string descricao, int poder): base(nome,descricao)
        {
            this.Poder = poder;

            
        }
        public int Poder { get; set; }

        public void ExibirDadosPokemonPlus()
        {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine("Descrição do Pokemon: " + this.Descricao);
            Console.WriteLine("Poder do Pokemon: " + this.Poder);

        }

    }
}