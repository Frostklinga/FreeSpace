using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FreeSpace.Models
{
    public class DrivesAndFoldersModel
    {
        public DrivesAndFoldersModel()
        {
            Drives = GetDrives();
        }
        public List<CustomDriveInfo> Drives { get; private set; }

        private List<CustomDriveInfo> GetDrives()
        {
            foreach(var drive in DriveInfo.GetDrives)
            {
                var driveInfo = new CustomizedDriveInfo();
            }
        }
    }
}
