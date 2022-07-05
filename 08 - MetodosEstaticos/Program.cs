namespace _08_MetodosEstaticos
{
    public class Program
    {
        //Não precisa instanciar o objeto para ter acesso ao metodo e atributo se forem estaticos
        static void Main(string [] args)
        {
            Exemplo.Soma(10,10);
            Console.WriteLine("Ola, " + Exemplo.nome);
            
            
        }

    }
    
}