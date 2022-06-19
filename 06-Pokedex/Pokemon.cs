namespace _06_Pokedex
{
    public class Pokemon
    {
        public Pokemon()
        {
            this.Nome = string.Empty;
            this.Descricao = string.Empty;
        }

        public Pokemon(string nome, string descricao) //sobrecarga de construtor
        {
            this.Nome = nome;
            this.Descricao = descricao;
        }
        //Propriedades
        private string nome;
        public string Nome
        {
            get { return nome; }
            set 
            { 
                string texto = value.ToUpper();
                nome = texto;
            }
        }
        private string descricao; //armazena o valor da propriedade Descricao
        public string Descricao //represta a caracteristica Descricao do meu pokemon
        {
            get { return this.descricao; }
            set { this.descricao = value.ToUpper(); }
        }

        //Metodos 
        public void ExibirDadosPokemon()
        {
            Console.WriteLine("Nome do Pokemon: " + this.Nome);
            Console.WriteLine("Descrição do Pokemon: " + this.Nome);
        }

        public void ExibirDadosPokemon(bool formatado) //sobrecarga de metodo
        {
            if (formatado == true)
            {
                Console.WriteLine("Pokemon " + this.Nome + ": " + this.Descricao.ToLower());
            }
            else
            {
                Console.WriteLine("Nome do Pokemon: " + this.Nome);
                Console.WriteLine("Descrição do Pokemon: " + this.Nome);
            }

        }
        
        
    }
}