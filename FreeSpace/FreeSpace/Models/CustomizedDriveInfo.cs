using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace FreeSpace.Models
{
    public class CustomDriveInfo
    {
        public CustomDriveInfo(DriveInfo info)
        {
            try
            {
                InitializeValues(info);
            }
            catch(IOException ) 
            {
                DriveNotAvailable();
            }
            catch(Exception e)
            {
                Debug.WriteLine($"Caught an exception in class {nameof(CustomDriveInfo)}. Message: {e.Message}");
            }
        }
        private void InitializeValues(DriveInfo info)
        {
            Name = info.Name;
            Total = new CustomDriveSize(info.TotalSize);
            Free = new CustomDriveSize(info.AvailableFreeSpace);
            PercentUsed = Convert.ToDouble(info.AvailableFreeSpace / info.TotalSize);
            PercentUsed = Math.Round(PercentUsed, PercentDecimals);
            DriveType = info.DriveType;
            IsAvailable = info.IsReady;
            RootDirectory = info.RootDirectory;
        }
        private void DriveNotAvailable()
        {
            Name = "";
        }
        public string ?Name { get; private set; } 
        public CustomDriveSize ?Total { get; private set; }
        public CustomDriveSize ?Free { get; private set; }
        public double PercentUsed { get; private set; } = 0.0;
        public DriveType ?DriveType { get; private set; }
        public bool IsAvailable { get; private set; } = false;
        public DirectoryInfo ?RootDirectory { get; private set; }

        private int PercentDecimals { get; set; } = 2;
    }
}
