using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vegetables.View
{
    public class VegetablesFruitsView
    {
        public double VegetablePrice { get; set; }
        public double FruitPrice { get; set; }
        public int VegetableKG { get; set; }
        public int FruitKG { get; set; }
        public double ResultBGN { get; set; }
        public double ResultEUR { get; set; }

        public void Input()
        {
            Console.Write("Enter price of the vegetable: ");
            VegetablePrice = double.Parse(Console.ReadLine());
            Console.Write("Enter price of the fruit: ");
            FruitPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter the kg of the vegetable: ");
            VegetableKG = int.Parse(Console.ReadLine());
            Console.Write("Enter kg of the fruit: ");
            FruitKG = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"{ResultEUR} euro");
        }
    }
}
