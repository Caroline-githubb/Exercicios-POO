namespace _05_AreaRetangulo
{
    public class Retangulo
    {
        public Retangulo()
        {
            this.Altura = 0;
            this.Base = 0;
        }

        private int _base;
        public int Base
        {
            get { return _base; }
            set 
            { 
                if (value >= 0) _base = value;
                else _base = 0; 
            }
        }

        private int altura;
        public int Altura
        {
            get { return altura; }
            set 
            { 
                if (value >= 0) altura = value;
                else altura = 0; 
            }
        }

        public int Area 
        { 
            get {return altura * _base;}
        }

        public void ExibirDados()
        {
            Console.WriteLine("Base: " + this.Base);
            Console.WriteLine("Altura: " + this.Altura);
            Console.WriteLine("Area: " + this.Area);
            
        }
        
        
        
    }
}