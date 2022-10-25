using System;

public class Chassis
{
    public int WheelsNumber { get; set; }
    public int Number { get; set; }
    public int PermissibleLoad { get; set; }

    public Chassis(int wheelsNumber, int number, int permissibleLoad)
    {
        Number = number;
        WheelsNumber = wheelsNumber;
        PermissibleLoad = permissibleLoad;
    }

}
