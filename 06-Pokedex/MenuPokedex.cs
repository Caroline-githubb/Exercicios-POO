namespace _06_Pokedex
{
    public class MenuPokedex
    {
        private int Menu()
        {
            Console.WriteLine("POKEDEX ---- AGENDA DE POKEMON");
            Console.WriteLine("------------------------------");
            Console.WriteLine("0 - Sair da Pokedex");
            Console.WriteLine("1 - Listar todos os Pokemons");
            Console.Write("O que deseja fazer? ");
            int resp = int.Parse(Console.ReadLine() + "");
            return resp;
        }

        public void ExibirMenu()
        {
            int opcao;

            do
            {
                opcao = Menu();
                switch(opcao)
                {
                    case 0:
                        break;
                    case 1:
                        Pokedex pokedex = new Pokedex();
                        pokedex.ListarPokemons();
                        break;                  
                }    
            }while(opcao != 0);
        }
    }
}