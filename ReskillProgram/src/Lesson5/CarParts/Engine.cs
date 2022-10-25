using System;

public class Engine
{
    public string Power { get; set; }
    public int Volume { get; set; }
    public string Type { get; set; }
    public string SerialNumber { get; set; }

    public Engine(string power, int volume, string type, string serialNumber)
    {
        this.Power = power;
        this.Volume = volume;
        this.Type = type;
        this.SerialNumber = serialNumber;
    }
}
