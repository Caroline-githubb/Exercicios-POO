namespace _07_PropriedadesSimplificadas
{
    public class Pergunta
    {
        public Pergunta()
        {
            this.Texto = "";
            this.Resposta = "";
        }
        public Pergunta(string texto, string resposta)
        {
            this.Texto = texto;
            this.Resposta = resposta;
        }
        public string Texto { get; set; }
        public string Resposta { get; set; }


    }
}