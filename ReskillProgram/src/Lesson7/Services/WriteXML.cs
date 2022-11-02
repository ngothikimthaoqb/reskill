using ReskillProgram.src.Lesson4.CarParts;
using ReskillProgram.src.Lesson4.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ReskillProgram.src.Lesson7.Services
{
    public class WriteXML
    {

        public void VehiclesEngineCapacitiesToXML(string fileName, List<Vehicle> vehicles)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Bus), typeof(Truck), typeof(Scooter), typeof(PassengerCar) });
            FileStream vefhicleInfoStream = File.OpenWrite(@fileName);
            serializer.Serialize(vefhicleInfoStream, vehicles);
        }

        public void EngineInforToXML(string fileName, List<Engine> engines)
        {
            XmlSerializer enginesSerializer = new XmlSerializer(typeof(List<Engine>));
            FileStream enginesStream = File.OpenWrite(@fileName);
            enginesSerializer.Serialize(enginesStream, engines);
        }


        public void VehiclesInfoGoupByTranmission(string fileName, List<Vehicle> vehicles)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Vehicle>), new Type[] { typeof(Bus), typeof(Truck), typeof(Scooter), typeof(PassengerCar) });
            FileStream vefhicleInfoStream = File.OpenWrite(@fileName);
            serializer.Serialize(vefhicleInfoStream, vehicles);
        }

    }
}
