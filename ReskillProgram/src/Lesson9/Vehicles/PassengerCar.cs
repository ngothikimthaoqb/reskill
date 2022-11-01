using ReskillProgram.src.Lesson9.Vehicles;
using System;

public class PassengerCar : Vehicle, IDisposable
{

    public override void Dispose()
    {
        try
        {
            Dispose(true); //true: safe to free managed resources
        }
        finally
        {
            base.Dispose();
        }
    }


}
