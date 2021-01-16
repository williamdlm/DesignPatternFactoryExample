using DesignPatternFactoryExample.ConcreteProduct;
using DesignPatternFactoryExample.Creator;
using DesignPatternFactoryExample.Product;

namespace DesignPatternFactoryExample.ConcreteCreator
{
    public class XboxFactory : VideogameFactory
    {
        private int _valor;
        private int _tamanhoHD;

        public XboxFactory(int valor, int tamanhoHD)
        {
            this._valor = valor;
            this._tamanhoHD = tamanhoHD;
        }

        public override Videogame BuscarVideogame()
        {
            return new Xbox(_valor, _tamanhoHD);
        }
    }
}