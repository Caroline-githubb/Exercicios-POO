namespace _01_AnimalDeEstimacao
{
    public class Animal
    {
        private string _nome = string.Empty;
        public string Nome
        {
            get { return _nome; } //pegar o valor de algum lugar privado
            set { _nome = value.ToUpper(); } //devolver o valor contido em nome para quem solicitou. ToUpper->a primeira letra smp será maiuscula
        }

        private string _tipo = string.Empty;
        public string Tipo
        {   //valores definidos pelo solicitante do sistema  - Cachorro, Gato, Peixe

            get { return _tipo; }
            set 
            { 
                if(value == "Cachorro" || value == "Gato" || value == "Peixe") 
                {
                    _tipo = value;
                }
                else
                {
                    _tipo = "Peixe";
                }
            }
        }
     
    }
}