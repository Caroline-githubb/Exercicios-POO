namespace _07_PropriedadesSimplificadas
{
    public class PerguntaPlus : Pergunta
    {
        public PerguntaPlus() : base()
        {   
            this.Dica = "";
        }
        public PerguntaPlus(string texto, string resposta,string dica) : base(texto, resposta)
        {
            this.Dica = "";
            
        }

        public string Dica { get; set; }
        

    }
}