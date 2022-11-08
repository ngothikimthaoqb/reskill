using Lesson4.CustomExceptions;


namespace Lesson4.CarParts
{
    public class Transmission
    {
        public string Type { get; set; }
        public int NumberOfGears { get; set; }
        public string Manufacturer { get; set; }

        protected Transmission() { }
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
