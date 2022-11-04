using Lesson4.CarParts;
using Lesson4.CustomExceptions;

namespace Lesson4.Vehicles
{
    public class PassengerCar : Vehicle, IDisposable
    {
        public PassengerCar() { }
        public PassengerCar(Chassis chassis, Transmission transmission, Engine engine) : base(chassis, transmission, engine)
        {
         
        }

        public void Dispose()
        {
            if (Chassis == null || Transmission == null || Engine == null)
            {
                throw new RemoveAutoException();
            }
        }

        public override string ToString()
        {
            return "PassengerCar Chassis: " + Chassis + "\n" + "PassengerCar Engine: " + Engine + "\n" + "PassengerCar Transmission: " + Transmission + "\n";
        }

    }
}
