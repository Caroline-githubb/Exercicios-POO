using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_JogoAndarEPular
{
    public class Player
    {
        public Byte Posicao { set; get; }
        public String Aparencia { set; get; }
        public String FacingRight { set; get; }
        public String FacingLeft { set; get; }
        public Boolean Pulando { set; get; }

        public Player(String right, String left)
        {
            Posicao = 0;
            FacingRight = right;
            FacingLeft = left;
            Aparencia = FacingRight;
            Pulando = false;
        }

        public void Pula()
        {
            Console.Beep(234, 100);
        }

        public void Anda(Boolean direcao, Byte limite)
        {
            if (direcao)
            {
                if (Posicao < limite)
                {
                    Posicao++;
                    Aparencia = FacingRight;
                }
            }
            else
            {
                if (Posicao > 0)
                {
                    Posicao--;
                    Aparencia = FacingLeft;
                }
            }
        }
    }
}