namespace _01_AnimalDeEstimacao
{
    public class Program
    {
        static void Main(string [] args)
        {
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPexe = 0;

            Console.WriteLine("Controle de animais");

            Console.Write("Informe o nome do 1º animal: ");
            a1.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 1º animal(Cachorro, Gato ou Peixe): ");
            a1.Tipo = Console.ReadLine();
            if (a1.Tipo == "Cachorro") tlCachorro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPexe++;

            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 2º animal: ");
            a2.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 2º animal(Cachorro, Gato ou Peixe): ");
            a2.Tipo = Console.ReadLine();
            if (a2.Tipo == "Cachorro") tlCachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPexe++;

            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 3º animal: ");
            a3.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 3º animal(Cachorro, Gato ou Peixe): ");
            a3.Tipo = Console.ReadLine();
            if (a3.Tipo == "Cachorro") tlCachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPexe++;

            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 4º animal: ");
            a4.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 4º animal(Cachorro, Gato ou Peixe): ");
            a4.Tipo = Console.ReadLine();
            if (a4.Tipo == "Cachorro") tlCachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPexe++;

            Console.WriteLine("Controle de animais");
            Console.Write("Informe o nome do 5º animal: ");
            a5.Nome = Console.ReadLine();
            Console.Write("Informe o tipo do 5º animal(Cachorro, Gato ou Peixe): ");
            a5.Tipo = Console.ReadLine();
            if (a5.Tipo == "Cachorro") tlCachorro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlPexe++;          

            //Resultado
            Console.WriteLine("Total de animais");
            Console.WriteLine("Cachorros: " + tlCachorro +" | Gatos: " + tlGato + " | Peixes: " + tlPexe);
            Console.ReadKey();


        }
    }
}
