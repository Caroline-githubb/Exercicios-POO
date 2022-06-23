namespace _06_Pokedex
{
    public class Pokedex
    {
        public Pokedex()
        {
            this.InicializaLista();
            
        }
        //Propriedades
        private List<Pokemon> pokemons; //é uma lista que armazena objetos do tipo pokemon        
        public List<Pokemon> Pokemons
        {
            get { return pokemons; } //não tem o set, pois os usuários só vão conseguir pegar(ler) os dados dos pokemons
        }
        private void InicializaLista()
        {
            //Instanciar a lista
            pokemons = new List<Pokemon>();
            this.pokemons = new List<Pokemon>();
            Pokemon p = new Pokemon("Bulbassauro", "pokemon tipo planta.");
            this.pokemons.Add(p);
            p = new Pokemon("Mew", "lendário psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Mewtwo", "lendario psiquico");
            this.pokemons.Add(p);
            p = new Pokemon("Giratina", "lendario fantasma");
            this.pokemons.Add(p);
            p = new Pokemon("Flygon", "pokemon dragão");
            this.pokemons.Add(p);
            p = new Pokemon("Metagross", "pokemon de metal");
            this.pokemons.Add(p);
            p = new Pokemon("Muk", "pokemon de metal");
            this.pokemons.Add(p);
            p = new Pokemon("Mudkip", "pokemon de água");
            this.pokemons.Add(p);
            p = new Pokemon("Lucario", "lutador lendariowannabe");
            this.pokemons.Add(p);
            p = new Pokemon("Paras", "pokemon de inseto");
            this.pokemons.Add(p);            
        }

        public void ListarPokemons()
        {
            for (int i = 0; i < Pokemons.Count; i++)
            {
                this.Pokemons[i].ExibirDadosPokemon();
                // Pokemon p = this.Pokemons[i];
                // p.ExibirDadosPokemon();
            }
        }    

        
    }
}