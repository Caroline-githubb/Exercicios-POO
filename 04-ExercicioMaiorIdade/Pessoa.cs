namespace _04_ExercicioMaiorIdade
{
    public class Pessoa
    {
        //propriedades
        private string nome = string.Empty;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set 
            { 
                if (value >= 0)
                {
                    idade = value;
                }
                else
                {
                    this.idade = 0;
                }            
            }
        }
        
        public Pessoa()
        {
            this.Nome = "";
            this.Idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        //Metodos
        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Idade: " + this.Idade);
        }
        

    }
}