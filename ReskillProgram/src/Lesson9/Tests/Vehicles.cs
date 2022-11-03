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

        public Vehicle GetTransportByParameter(List<Vehicle> vehicles, string paramater, string value)
        {

            bool isExist = false;
            foreach (Vehicle vehicle in vehicles)
            {
                foreach (var prop in vehicle.GetType().GetProperties())
                {
                    if (prop.Name == paramater)
                    {
                        if (prop.GetValue(vehicle, null) == value)
                        {
                            isExist = true;
                            return vehicle;
                        };
                    }
                }
            }

            if (!isExist)
            {
                throw new  GetAutoByParameterException("Auto wasn't found by" + paramater + "=" + value);
            }

            return null;
        }

    }
}
