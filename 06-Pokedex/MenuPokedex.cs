namespace _06_Pokedex
{
    public class MenuPokedex
    {
        private int Menu()
        {
            Console.WriteLine("POKEMON-- JOGO DE BATALHA");
            Console.WriteLine("------------------------------");
            Console.WriteLine("0 - Sair do jogo");
            Console.WriteLine("1 - Listar todos os Pokemons da Pokedex");
            Console.WriteLine("2 - Batalhar");
            Console.Write("O que deseja fazer? ");
            int resp = int.Parse(Console.ReadLine() + "");
            return resp;
        }

        public void ExibirMenu()
        {
            Pokedex pokedex = new Pokedex();
            int opcao;
            do
            {
                opcao = Menu();
                switch(opcao)
                {
                    case 0:
                        break;
                    case 1:                        
                        pokedex.ListarPokemons();
                        break;
                    case 2:
                        pokedex.ListarPokemons();
                        Console.Write("Digite o código do Pokemon: ");
                        int codigo = Convert.ToInt32(Console.ReadLine());     
                        //pegar o pokemon do player
                        PokemonPlus pPlayer = pokedex.Pokemons[codigo];    
                        //definir o pokemon do pc               
                        Random r = new Random();
                        codigo = r.Next(0,pokedex.Pokemons.Count);
                        PokemonPlus pPc = pokedex.Pokemons[codigo]; 
                        //batalhar
                        if (pPlayer.Poder >= pPc.Poder)
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Parabéns, você venceu a batalha!");
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Dados do seu Pokemon: ");
                            pPlayer.ExibirDadosPokemonPlus();
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Dados do seu oponente: ");
                            pPc.ExibirDadosPokemonPlus();
                        }
                        else
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Que pena, você perdeu a batalha!");
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Dados do seu Pokemon: ");
                            pPlayer.ExibirDadosPokemonPlus();
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine("Dados do seu oponente: ");
                            pPc.ExibirDadosPokemonPlus();
                        }
                        break;                  
                }    
            }while(opcao != 0);
        }
    }
}