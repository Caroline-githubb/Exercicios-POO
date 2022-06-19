namespace _02_CalculoIdade
{
    public class Pessoa
    {   
        public int anoNascimento;

        private int idade; //variavel do tipo inteiro privada

        private string nome = string.Empty;

        public Pessoa(string nome, int anoNascimento)
        {
            this.Nome = nome;
            this.AnoNascimento = anoNascimento;
            this.CalcularIdade();
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }        

        public int AnoNascimento
        {
            get { return this.anoNascimento;}
            set {this.anoNascimento = value;}
        }
        public int Idade //criei uma propriedade do tipo inteiro publico para interagir com a variavel
        {
            get 
            {
                this.CalcularIdade();
                return this.idade; 
            } //pega o valor da variavel idade e entrega para quem efetuar a chamada
            /*set { this.idade = value; }pega o valor do usuário e armazena na variavel idade - nesse caso não usarei o metodo set,
            pois, eu que irei calcular a idade para o usuário*/
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Ano nascimento: " + this.anoNascimento);          
            Console.WriteLine("Idade: " + this.Idade);  
        }

        public void CalcularIdade()
        {
            DateTime data = DateTime.Now; //data do sistema atual
            int ano = data.Year; //data do ano atual
            this.idade = ano - this.anoNascimento;             
        }

        
        
    }
} 