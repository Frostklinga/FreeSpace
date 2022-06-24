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
            
        }
        public DriveInfo[] Drives { get; private set; } = DriveInfo.GetDrives();
    }
}
