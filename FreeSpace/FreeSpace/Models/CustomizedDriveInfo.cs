using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FreeSpace.Models
{
    public class CustomizedDriveInfo
    {
        public CustomizedDriveInfo(DriveInfo info)
        {
            Name = info.Name;
            Total = new CustomDriveSize()
        }
        public string Name { get; private set; }
        public CustomDriveSize Total { get; private set; }
        public CustomDriveSize Free { get; private set; }
        public decimal PercentUsed { get; private set; }
        public DriveType DriveType { get; private set; }
        public bool IsAvailable { get; private set; }
    }
}
