using ReskillProgram.src.Lesson9.CustomException;
using ReskillProgram.src.Lesson9.Vehicles;
using ReskillProgram.src.Lesson9.XMLModel;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReskillProgram.src.Lesson5.Tests
{

    public class VehicleCollectionTest
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

            try
            {
                passengerCar = new PassengerCar() { Chassis = passengerCarChassis, Transmission = passengerCarTransmission, Engine = passengerCarEngine };
            }
            catch(TypeInitializationException e)
            {
                throw e;
            }
         
            try
            {
                vehiclesCollection.Add(passengerCar);
            }
            catch (Exception e)
            {
                throw e;
            }

            PassengerCar passengerException = new PassengerCar();

            // GetAutoByParameterException
            try
            {
                passengerException.Transmission.GetManufacturer();
            }
            catch (Exception e)
            {
                throw e;
            }

            // UpdateAutoException 

            // RemoveAutoException

            try
            {

                passengerException.Dispose();
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}
