using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Vegetables.Model
{
    public class FruitAndVegetablesModel
    {
        private double vegetablePrice;
        private double fruitPrice;
        private int vegetableKG;
        private int fruitKG;
        public double VegetablePrice
        {
            get { return vegetablePrice; }
            set
            {
                if (value <= 0.00 || value >= 1000.00)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                vegetablePrice = value;
            }
        }
        public double FruitPrice
        {
            get { return fruitPrice; }
            set
            {
                if (value <= 0.00 || value >= 1000.00)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                fruitPrice = value;
            }
        }
        public int VegetableKG
        {
            get { return vegetableKG; }
            set
            {
                if (value <= 0 || value >= 1000)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                vegetableKG = value;
            }
        }
        public int FruitKG
        {
            get { return fruitKG; }
            set
            {
                if (value <= 0 || value >= 1000)
                {
                    throw new ArgumentOutOfRangeException("Argument out of range");
                }
                fruitKG = value;
            }
        }
        public FruitAndVegetablesModel(double vegetablePrice, double fruitPrice, int vegetableKG, int fruitKG)
        {
            this.VegetableKG = vegetableKG;
            this.VegetablePrice = vegetablePrice;
            this.FruitPrice = fruitPrice;
            this.FruitKG = fruitKG;
        }
        public FruitAndVegetablesModel()
        {
        }
        public double CalculateResultBGN()
        {
            return (VegetablePrice * VegetableKG) + (FruitPrice * FruitKG);
        }
        // Converts the total cost from BGN to Euro
        public double ConvertToEuro()
        {
            double BGNtoEUR = 1.94;
            return CalculateResultBGN() / BGNtoEUR;
        }
    }
}
