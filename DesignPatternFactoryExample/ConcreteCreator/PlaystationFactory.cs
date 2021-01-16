using DesignPatternFactoryExample.ConcreteProduct;
using DesignPatternFactoryExample.Creator;
using DesignPatternFactoryExample.Product;

namespace DesignPatternFactoryExample.ConcreteCreator
{
    public class PlaystationFactory : VideogameFactory
    {
        private int _valor;
        private int _tamanhoHD;

        public PlaystationFactory(int valor, int tamanhoHD)
        {
            this._valor = valor;
            this._tamanhoHD = tamanhoHD;
        }

        public override Videogame BuscarVideogame()
        {
            return new Playstation(_valor, _tamanhoHD);
        }
    }
}
