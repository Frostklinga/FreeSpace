using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSpace.HelperFunctions;

namespace FreeSpace.Models;
//TODO: I should convert this class to a factory instead... It would make it more type safe.
public class CustomDriveSize
{
    public CustomDriveSize(long size, SizePrefix prefix)
    {
        double s = (double)size;
        Size = ConvertToRoundedPrefix(size, prefix);
        Prefix = prefix;
        SizeAndPrefix = $"{Size} {Prefix}";
    }
    public CustomDriveSize(long size)
    {
        double s = (double)size;
        Prefix = CalculatePrefix(size);
        Size = ConvertToRoundedPrefix(size, Prefix);
        SizeAndPrefix = $"{Size} {Prefix}";
    }

    public double Size { get; private set; }
    public SizePrefix Prefix { get; private set; }
    public string SizeAndPrefix { get; private set; }
    public int SizeDecimals { get; set; } = 2;
    
    private SizePrefix CalculatePrefix(double size)
    {
        if (size > Math.Pow(2, 60))
            return SizePrefix.Exa;
        else if (size > Math.Pow(2, 50))
            return SizePrefix.Peta;
        else if (size > Math.Pow(2, 40))
            return SizePrefix.Tera;
        else if (size > Math.Pow(2, 30))
            return SizePrefix.Giga;
        else if (size > Math.Pow(2, 20))
            return SizePrefix.Mega;
        else if (size > Math.Pow(2, 10))
            return SizePrefix.Kilo;
        else
            return SizePrefix.None;
    }
    //Does not feel like a good solution, but i dont have any other sugestion.
    private double ConvertToRoundedPrefix(double size, SizePrefix prefix)
    {
        switch(prefix)
        {
            case SizePrefix.None:
                return Math.Round(size, SizeDecimals);
            case SizePrefix.Kilo:
                return Math.Round(size / Math.Pow(2, 10),SizeDecimals);
            case SizePrefix.Mega:
                return Math.Round(size / Math.Pow(2, 20), SizeDecimals);
            case SizePrefix.Giga:
                return Math.Round(size / Math.Pow(2, 30), SizeDecimals);
            case SizePrefix.Tera:
                return Math.Round(size / Math.Pow(2, 40), SizeDecimals);
            case SizePrefix.Peta:
                return Math.Round(size / Math.Pow(2, 50), SizeDecimals);
            case SizePrefix.Exa:
                return Math.Round(size / Math.Pow(2, 60), SizeDecimals);
            default:
                throw new ArgumentOutOfRangeException("The provided size cannot be converted as the size is not supported.");
        }
    }
}
public enum SizePrefix
{
    None = 0,
    Kilo = 10,
    Mega = 20,
    Giga = 30,
    Tera = 40,
    Peta = 50,
    Exa = 60
}