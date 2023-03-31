using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Classes_oop
{
    abstract class BikeForks
    {

        static string[] forks = { "Fox", "RockShocks", "CaneCreek", "Cannondaile", "SunTour", "Giant", "Spinner", "Marzocchi" };
        static string[] types = { "Spring", "SpringOil", "OilAir", "Air", "Hard" };
        static public void showBrands()
        {
            foreach (string fork in forks)
            {
                Console.WriteLine(fork);
            }
        }
        static public void showTypes()
        {

            foreach (string type in types)
            {
                Console.WriteLine(type);
            }

        }
        public abstract void showForkInfo();
        protected abstract void createFork();
    }
}
