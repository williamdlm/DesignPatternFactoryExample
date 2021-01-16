using DesignPatternFactoryExample.Product;

namespace DesignPatternFactoryExample.ConcreteProduct
{
    public class Playstation : Videogame
    {
        private readonly string _tipoVideogame;
        private int _valor;
        private int _tamanhoHD;

        public Playstation(int valor, int tamanhoHD)
        {
            this._tipoVideogame = "Playstation";
            this._valor = valor;
            this._tamanhoHD = tamanhoHD;
        }

        public override string TipoVideogame
        {
            get { return _tipoVideogame; }
        }
        public override int Valor
        {
            get { return _valor; }
            set { _valor = value; }
        }
        public override int TamanhoHD
        {
            get { return _tamanhoHD; }
            set { _tamanhoHD = value; }
        }
    }
}