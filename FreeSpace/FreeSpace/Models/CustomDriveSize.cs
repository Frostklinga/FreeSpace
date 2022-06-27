using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSpace.HelperFunctions;

namespace FreeSpace.Models
{
    public class CustomDriveSize
    {
        public CustomDriveSize(long size, SizePrefix prefix)
        {
            decimal s = (decimal)size;
            Size = Convert(size, prefix);
            Prefix = prefix;
        }
        public CustomDriveSize(long size)
        {
            SizePrefix prefix = CalculatePrefix(size);
            Size = Convert(size, prefix);
        }
        public decimal Size { get; private set; }
        public SizePrefix Prefix { get; private set; }
        private int SizeDecimals { get; set; } = 2;

        private SizePrefix CalculatePrefix(long size)
        {
            int prefixAsNumber = 0;
            while(size > 1024)
            {
                prefixAsNumber += 10;
                size /= 1024;
            }
            return (SizePrefix)prefixAsNumber;
        }
        //Feel that this is not a very good solution.
        private double Convert(double size, SizePrefix prefix)
        {
            switch(prefix)
            {
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
        Kilo = 10,
        Mega = 20,
        Giga = 30,
        Tera = 40,
        Peta = 50,
        Exa = 60
    }
}
