using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson9.CustomExceptions;

namespace ReskillProgram.src.Lesson4.Vehicles
{
    public class PassengerCar : Vehicle, IDisposable
    {
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
