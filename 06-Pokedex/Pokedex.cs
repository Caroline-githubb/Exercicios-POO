namespace _06_Pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
            
        }
        //Propriedades
        private List<PokemonPlus> pokemons; //é uma lista que armazena objetos do tipo pokemon        
        public List<PokemonPlus> Pokemons
        {
            get { return pokemons; } //não tem o set, pois os usuários só vão conseguir pegar(ler) os dados dos pokemons
        }
        private void InicializaLista()
        {
            //Instanciar a lista            
            this.pokemons = new List<PokemonPlus>();
            PokemonPlus p = new PokemonPlus("Bulbassauro", "pokemon tipo planta", 100);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mew", "lendário psiquico", 90);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mewtwo", "lendario psiquico", 70);
            this.pokemons.Add(p);
            p = new PokemonPlus("Giratina", "lendario fantasma", 55);
            this.pokemons.Add(p);
            p = new PokemonPlus("Flygon", "pokemon dragão", 20);
            this.pokemons.Add(p);
            p = new PokemonPlus("Metagross", "pokemon de metal", 115);
            this.pokemons.Add(p);
            p = new PokemonPlus("Muk", "pokemon de metal", 50);
            this.pokemons.Add(p);
            p = new PokemonPlus("Mudkip", "pokemon de água", 60);
            this.pokemons.Add(p);
            p = new PokemonPlus("Lucario", "lutador lendariowannabe", 65);
            this.pokemons.Add(p);
            p = new PokemonPlus("Paras", "pokemon de inseto", 10);
            this.pokemons.Add(p);            
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                Console.WriteLine("Código do Pokemon: " + i);
                this.Pokemons[i].ExibirDadosPokemon();
                // Pokemon p = this.Pokemons[i];
                // p.ExibirDadosPokemon();
            }
        }    

        
    }
}