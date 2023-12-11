using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vegetables.View;
using Vegetables.Controller;
using Vegetables.Model;

namespace Vegetables.Controller
{
    public class VegetablesFruitsController
    {
        private FruitAndVegetablesModel model = new FruitAndVegetablesModel();
        private VegetablesFruitsView view= new VegetablesFruitsView();
        public VegetablesFruitsController() 
        {
            view.Input();
            model.VegetablePrice=view.VegetablePrice;
            model.VegetableKG= view.VegetableKG;
            model.FruitPrice=view.FruitPrice;
            model.FruitKG= view.FruitKG;
            view.ResultBGN = model.CalculateResultBGN();
            view.ResultEUR=model.ConvertToEuro();
            view.Output();
             
        }
    }
}
