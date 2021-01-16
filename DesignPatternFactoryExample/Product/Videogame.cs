namespace DesignPatternFactoryExample.Product
{
    public abstract class Videogame
    {
        public abstract string TipoVideogame { get; }

        public abstract int Valor { get; set; }

        public abstract int TamanhoHD { get; set; }
    }
}
