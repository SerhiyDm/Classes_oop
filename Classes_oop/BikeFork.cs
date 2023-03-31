using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_oop
{
    internal class BikeFork : BikeForks
    {
        private string brandName;
        private string model;
        private string type;
        private string stroke;
        public BikeFork()
        {
            Console.WriteLine("Hi! Нere you can assemble a bicycle fork with the type and parameters you want");
            this.createFork();
        }


        protected override void createFork()
        {
            Console.WriteLine("Enter brand name of bike fork. To recall names, use the list of brands names:");
            showBrands();
            Console.WriteLine("...or another brand name ");
            this.brandName = Console.ReadLine() + "";
            Console.WriteLine("...enter  name of model...(you can make it up)))...");
            this.model = Console.ReadLine() + "";
            Console.WriteLine("...enter  type of bike fork. To recall names, use the list of types:");
            showTypes();
            Console.WriteLine("...or another type ");
            this.type = Console.ReadLine() + "";
            Console.WriteLine("...enter number of millimeters (fork stroke)");
            this.stroke = Console.ReadLine() + "mm";
            if (this.type?.ToLower() == "hard") this.stroke = "";

        }
        public override void showForkInfo()
        {
            Console.WriteLine($"\n{this.brandName} {this.model}\ntype: {this.type}\nstroke: {this.stroke}");
        }




    }
}
