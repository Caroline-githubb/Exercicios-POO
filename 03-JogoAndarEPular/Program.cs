using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_JogoAndarEPular
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player("p","q");
            Cenario c = new Cenario("_", 60);
            ConsoleKey tecla;
            
            c.Imprime(p);

            do
            {
                tecla = Console.ReadKey().Key;

                switch (tecla)
                {
                    case ConsoleKey.LeftArrow:
                    //anda para esquerda
                    p.Anda(false, c.Tamanho);
                    c.Imprime(p);
                    break;
                    case ConsoleKey.UpArrow:
                    //PULA
                    p.Pulando = true;
                    c.Imprime(p);
                    p.Pula();
                    p.Pulando = false;
                    c.Imprime(p);
                    break;
                    default:
                    c.Imprime(p);
                    break;
                }
            } while(tecla != ConsoleKey.Escape);
        }
    }
}

