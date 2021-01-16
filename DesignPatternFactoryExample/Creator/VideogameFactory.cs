using DesignPatternFactoryExample.Product;

namespace DesignPatternFactoryExample.Creator
{
    public abstract class VideogameFactory
    {
        public abstract Videogame BuscarVideogame();
    }
}