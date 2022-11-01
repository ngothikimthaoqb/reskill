using ReskillProgram.src.Lesson9.CustomException;

namespace ReskillProgram.src.Lesson5.Tests
{

    public class ExceptionTest
    {
        static void Main(string[] args)
        {

            Chassis passengerCarChassis = new Chassis()
            {
                Number = 10,
                WheelsNumber = 10,
                PermissibleLoad = 100
            };
            Engine passengerCarEngine = new Engine()
            {
                Power = 100,
                SerialNumber = "HGFD11222",
                Type = "petrol",
                Volume = 50
            };
            Transmission passengerCarTransmission = new Transmission()
            {
                Manufacturer = "VWAGY",
                NumberOfGears = 10,
                Type = "Manual"

            };

            var vehiclesCollection = new List<object>();

            PassengerCar passengerCar;

            // TypeInitializationException
            try
            {
                passengerCar = new PassengerCar() { Chassis = passengerCarChassis, Transmission = passengerCarTransmission, Engine = passengerCarEngine };
            }
            catch(TypeInitializationException e)
            {
                throw e;
            }

            // AddException
            try
            {
                vehiclesCollection.Add(passengerCar);
            }
            catch (Exception e)
            {
                throw new AddException(passengerCar.Transmission.Type);
            }

            

            // GetAutoByParameterException
            try
            {
                PassengerCar passengerGetAutoByParameterException = new PassengerCar();
                passengerGetAutoByParameterException.Transmission.GetManufacturer();
            }
            catch (GetAutoByParameterException e)
            {
                throw e;
            }

            // UpdateAutoException
            try
            {
               
                passengerCar.Transmission.UpdateManufacture("MHKG");
            }
            catch (UpdateAutoException e)
            {
                throw e;
            }

            // RemoveAutoException
            try
            {

                passengerCar.Dispose();
            }
            catch (RemoveAutoException e)
            {
                throw e;
            }

        }
    }
}
