using Lesson4.CarParts;
using Lesson4.Vehicles;
using Lesson9.Tests;
using System.Xml.Serialization;

namespace Lesson7.Services
{
    public class WriteXML
    {

        public void VehiclesEngineCapacitiesToXML(string fileName, List<Vehicle> vehicles)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Bus), typeof(Truck), typeof(Scooter), typeof(PassengerCar) });
            FileStream vefhicleInfoStream = File.OpenWrite(fileName);
            serializer.Serialize(vefhicleInfoStream, vehicles);
        }

        public void EngineInfoToXML(string fileName, List<Engine> engines)
        {
            XmlSerializer enginesSerializer = new XmlSerializer(typeof(List<Engine>));
            FileStream enginesStream = File.OpenWrite(fileName);
            enginesSerializer.Serialize(enginesStream, engines);
        }


        public void VehiclesInfoGoupByTranmission(string fileName, List<Vehicle> vehicles)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Bus), typeof(Truck), typeof(Scooter), typeof(PassengerCar) });
            FileStream vefhicleInfoStream = File.OpenWrite(fileName);
            serializer.Serialize(vefhicleInfoStream, vehicles);
        }

    }

   
}
