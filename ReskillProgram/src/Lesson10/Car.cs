using ReskillProgram.src.Lesson4.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson10
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }

        public Car(string Brand, string Model, int Quantity, int Cost)
        {
            this.Brand = Brand;
            this.Model = Model;
            this.Quantity = Quantity;
            this.Cost = Cost;
        }
    }
}
