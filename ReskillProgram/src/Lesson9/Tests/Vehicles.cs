using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson4.Vehicles;
using ReskillProgram.src.Lesson9.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson9.Tests
{
    public class Vehicles
    {
        public List<Vehicle> InitVehicleCollection()
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

            Bus bus = new Bus(busChassis, busTransmission, busEngine);
            Truck truck = new Truck(truckChassis, truckTransmission, truckEngine);
            Scooter scooter = new Scooter(scooterChassis, scooterTransmission, scooterEngine);

            List<Vehicle> vehiclesCollection = new List<Vehicle>();

            // Collection 
            vehiclesCollection.Add(bus);
            vehiclesCollection.Add(truck);
            vehiclesCollection.Add(scooter);

            return vehiclesCollection;
        }

        public void GetTransportByParameter(string paramater, string value)
        {
            List<Vehicle> vehicles = InitVehicleCollection();
            bool isExist = false;
            foreach (Vehicle vehicle in vehicles)
            {
                foreach (var prop in vehicle.GetType().GetProperties())
                {
                    if (prop.GetValue(vehicle, null).ToString().Contains(paramater + ":" + value))
                    {
                        isExist = true;
                        Console.WriteLine("Vehicle found: \n" + string.Join(" ", vehicle.GetType()
                                .GetProperties()
                                .Select(prop => prop.GetValue(vehicle))));
                    }
                }
            }

            if (!isExist)
            {
                throw new  GetAutoByParameterException("Auto wasn't found by" + paramater + "=" + value);
            }

        }

    }
}
