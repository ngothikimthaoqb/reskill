using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson4.Vehicles;
using ReskillProgram.src.Lesson7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReskillProgram.src.Lesson7.Tests
{
    public class XMLTests
    {
        public static void Main(string[] args)
        {
            List<Vehicle> vehiclesCollection = new List<Vehicle>();

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
            PassengerCar passengerCar = new PassengerCar(passengerCarChassis, passengerCarTransmission, passengerCarEngine);

            // Collection 
            vehiclesCollection.Add(bus);
            vehiclesCollection.Add(truck);
            vehiclesCollection.Add(scooter);
            vehiclesCollection.Add(passengerCar);



            WriteXML writeXML = new WriteXML();

            // All information about all vehicles an engine capacity of which is more than 1.5 liters;
            writeXML.VehiclesEngineCapacitiesToXML("VehiclesMoreOnePointFiveLitter", vehiclesCollection);

            // Engine type, serial number and power rating for all buses and trucks;
            List<Engine> engines = new List<Engine>();
            writeXML.EngineInforToXML("EngineXML", engines);

            // All information about all vehicles, grouped by transmission type.
            writeXML.VehiclesEngineCapacitiesToXML("VehiclesGroupByTranmission", vehiclesCollection);


        }
    }
}
