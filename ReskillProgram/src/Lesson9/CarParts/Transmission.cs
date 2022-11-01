using ReskillProgram.src.Lesson9.CustomException;
using System;
using System.Xml.Linq;

public class Transmission
{
    public string? Type { get; set; }
    public int? NumberOfGears { get; set; }
    public string? Manufacturer { get; set; }

    public string GetManufacturer()
    {
        if (Manufacturer == null)
        {
            throw new GetAutoByParameterException();
        }

        return Manufacturer;
    }
	
    public void UpdateManufacture(string manufacture)
    {
        if (manufacture == null)
        {
            throw new UpdateAutoException(manufacture);
        }
        
        Manufacturer = manufacture.Trim();
    }
}
