using DesignPatternFactoryExample.ConcreteCreator;
using DesignPatternFactoryExample.Creator;
using DesignPatternFactoryExample.Product;
using System;

namespace DesignPatternFactoryExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VideogameFactory videogameFactory = null;
            Console.Write("Digite o tipo do videogame:");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "xbox":
                    videogameFactory = new XboxFactory(3000, 500);
                    break;

                case "playstation":
                    videogameFactory = new PlaystationFactory(3750, 2000);
                    break;

                case "nintendo":
                    videogameFactory = new NintendoFactory(3500, 1000);
                    break;

                default:
                    Console.WriteLine("Tipo do videogame está incorreto");
                    break;


            }

            Videogame videoGame = videogameFactory.BuscarVideogame();
            Console.WriteLine($"Especificações do videogame: \nTipoConsole: {videoGame.TipoVideogame} \nPreço: {videoGame.Valor}" +
                $" \nTamanhoHD: {videoGame.TamanhoHD}MBs");
            Console.ReadKey();

        }
    }
}