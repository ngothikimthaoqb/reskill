using ReskillProgram.src.Lesson9.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson4.CarParts
{
    public class Transmission
    {
        private string Type { get; set; }
        private int NumberOfGears { get; set; }
        private string Manufacturer { get; set; }

        public Transmission(string type, int numberOfGears, string manufacturer)
        {
            this.Type = type;
            this.NumberOfGears = numberOfGears;
            this.Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return "Transmission: " + "\n" + "Type:" + Type + "\n" + "NumberOfGears:" + NumberOfGears + "\n" + "Type:" + Type + "\n" + "Manufacturer:" + Manufacturer;
        }


        public void UpdateManufacture(string manufacture)
        {
            if (manufacture == null)
            {
                throw new UpdateAutoException(manufacture);
            }

            Manufacturer = manufacture.Trim();
        }
    }
}
