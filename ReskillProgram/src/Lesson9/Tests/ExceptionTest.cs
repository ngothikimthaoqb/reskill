using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson4.Vehicles;
using ReskillProgram.src.Lesson9.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.Tests
{
    public class ExceptionTest
    {
        static void Main(string[] args)
        {
            Chassis busChassis = new Chassis(10, 110, 100);
            Engine busEngine = new Engine("high", 30, "petrol", "HGF112122");
            Transmission busTransmission = new Transmission("Auto", 20, "VWAGDFY");


            Chassis truckChassis = new Chassis(10, 90, 100);
            Engine truckEngine = new Engine("low", 30, "petrol", "HGF11212U2");
            Transmission truckTransmission = new Transmission("Manual", 20, "VWHAGDFY");

            Chassis scooterChassis = new Chassis(10, 10, 100);
            Engine scooterEngine = new Engine("medium", 30, "petrol", "HGF11212U2");
            Transmission scooterTransmission = new Transmission("Auto", 20, "VWHAGDFY");

            Chassis passengerCarChassis = new Chassis(10, 50, 100);
            Engine passengerCarEngine = new Engine("medium", 60, "petrol", "HGF11212U2");
            Transmission passengerCarTransmission = new Transmission("Manual", 20, "VWHAGDFY");


            Bus bus = new Bus(busChassis, busTransmission, busEngine);
            Truck truck = new Truck(truckChassis, truckTransmission, truckEngine);
            Scooter scooter = new Scooter(scooterChassis, scooterTransmission, scooterEngine);

            var vehiclesCollection = new List<Vehicle>();

            // Collection 
            vehiclesCollection.Add(bus);
            vehiclesCollection.Add(truck);
            vehiclesCollection.Add(scooter);
           

            PassengerCar passengerCar;

            // TypeInitializationException
            try
            {
                passengerCar = new PassengerCar(passengerCarChassis, passengerCarTransmission, passengerCarEngine);

            }
            catch (TypeInitializationException e)
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
                Console.WriteLine(e);
                throw new AddException();
            }



            // GetAutoByParameterException
            try
            {
                GetTranportByParameter(busTransmission, vehiclesCollection);
            }
            catch (GetAutoByParameterException e)
            {
                throw e;
            }

            // UpdateAutoException
            try
            {

                passengerCar.Transmission.UpdateManufacture(null);
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

        public static void GetTranportByParameter(Transmission tranmission, List<Vehicle> vehicles)
        {
            bool isExist = false;
            vehicles.ForEach(vehicle =>
            {
            if (vehicle.Transmission == tranmission)
                {
                    isExist = true;
                }
            });

           if(isExist == false)
           {
                throw new GetAutoByParameterException();
           }
        }
    }
}
