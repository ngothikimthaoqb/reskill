using ReskillProgram.src.Lesson5.Vehicles;
using ReskillProgram.src.Lesson5.XMLModel;
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
            var vehiclesCollection = new List<object>();

            Chassis busChassis = new Chassis()
            {
                Number = 10,
                WheelsNumber = 110,
                PermissibleLoad = 100
            };
            Engine busEngine = new Engine()
            {
                Power = 30,
                SerialNumber = "HGF112122",
                Type = "petrol",
                Volume = 100
            };
            Transmission busTransmission = new Transmission()
            {
                Manufacturer = "VWAGDFY",
                NumberOfGears = 20,
                Type = "Auto"
              
            };

            Chassis truckChassis = new Chassis()
            {
                Number = 10,
                WheelsNumber = 50,
                PermissibleLoad = 100
            };
            Engine truckEngine = new Engine()
            {
                Power = 30,
                SerialNumber = "HGF1D1222",
                Type = "petrol",
                Volume = 200
            };
            Transmission truckTransmission = new Transmission()
            { 
                Manufacturer = "VWASGY",
                NumberOfGears = 10,
                Type = "Manual"

            };

            Chassis scooterChassis = new Chassis()
            {
                Number = 10,
                WheelsNumber = 10,
                PermissibleLoad = 100
            };
            Engine scooterEngine = new Engine()
            {
                Power = 30,
                SerialNumber = "HGF1D1222",
                Type = "petrol",
                Volume = 100
            };
            Transmission scooterTransmission = new Transmission()
            {
                Manufacturer = "VWAGY",
                NumberOfGears = 10,
                Type = "Auto"

            };
         
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

            Bus bus = new Bus() { Chassis = busChassis, Transmission = busTransmission, Engine = busEngine };
            Truck truck = new Truck() { Chassis = truckChassis, Transmission = truckTransmission, Engine = truckEngine };
            Scooter scooter = new Scooter() { Chassis = scooterChassis, Transmission = scooterTransmission, Engine = scooterEngine };
            PassengerCar passengerCar = new PassengerCar() { Chassis = passengerCarChassis, Transmission = passengerCarTransmission, Engine = passengerCarEngine };

            // Collection 
            vehiclesCollection.Add(bus);
            vehiclesCollection.Add(truck);
            vehiclesCollection.Add(scooter);
            vehiclesCollection.Add(passengerCar);

            // Write the following information to the corresponding XML files:

            // All information about all vehicles an engine capacity
            VehicleInfoXML vehicleInfoXML = new VehicleInfoXML()
            {
                Bus = bus,
                Truck = truck,
                PassengerCar = passengerCar,
                Scooter = scooter
            };
       

            XmlSerializer vefhicleInfoSerializer = new XmlSerializer(typeof(VehicleInfoXML));
            FileStream vefhicleInfoStream = File.OpenWrite(@"VehicleInfo.xml");
            vefhicleInfoSerializer.Serialize(vefhicleInfoStream, vehicleInfoXML);
            vefhicleInfoStream.Dispose();

            // Engine type, serial number and power rating for all buses and trucks;
            List<Engine> engines = new List<Engine>();
            engines.Add(busEngine);
            engines.Add(truckEngine);

            EngineXML engineXML = new EngineXML(){Engines = engines};
            XmlSerializer engineSerializer = new XmlSerializer(typeof(EngineXML));
            FileStream engineStream = File.OpenWrite(@"Engine.xml");
            engineSerializer.Serialize(engineStream, engineXML);
            engineStream.Dispose();

            // All information about all vehicles, grouped by transmission type.
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(bus);
            vehicles.Add(scooter);
            vehicles.Add(truck);
            vehicles.Add(passengerCar);

            var vehicleListByTranmissonType = vehicles.GroupBy(vehicle => vehicle.Transmission.Type)
                .Select(grp => grp.ToList())
                .ToList();

            VehicleXML vehicleXML = new VehicleXML() { Vehicles = vehicleListByTranmissonType };
            XmlSerializer vehicleXMLSerializer = new XmlSerializer(typeof(VehicleXML));
            FileStream vehicleXMLStream = File.OpenWrite(@"VehicleGoupByTranssionType.xml");
            vehicleXMLSerializer.Serialize(vehicleXMLStream, vehicleXML);
            vehicleXMLStream.Dispose();
        }
    }
}
