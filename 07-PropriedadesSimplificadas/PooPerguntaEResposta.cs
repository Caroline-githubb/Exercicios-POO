namespace _07_PropriedadesSimplificadas
{
    public class PooPerguntaEResposta
    {
        private string texto;
        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }

        //Quando utilizar essa classe, vai criar uma variavel para armazenar os dados da propriedade (é criada em tempo de execução)
        //O metodo get vai pegar o valor dessa váriavel, e o set vai setar o valor nessa variavel;
        //quando não quer alterar o metodo get e set, utiliza-se o metodo simplificado;
       public string Resposta { get; set; }

    }
}