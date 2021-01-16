using DesignPatternFactoryExample.ConcreteProduct;
using DesignPatternFactoryExample.Creator;
using DesignPatternFactoryExample.Product;

namespace DesignPatternFactoryExample.ConcreteCreator
{
    internal class NintendoFactory : VideogameFactory
    {
        private int _valor;
        private int _tamanhoHD;

        public NintendoFactory(int valor, int tamanhoHD)
        {
            this._valor = valor;
            this._tamanhoHD = tamanhoHD;
        }

        public override Videogame BuscarVideogame()
        {
            return new Nintendo(_valor, _tamanhoHD);
        }
    }
}