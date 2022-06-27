using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreeSpace.Models;
using System.IO;

namespace FreeSpace.HelperFunctions
{
    public static class GetDrivesInfo
    {
        public static List<CustomizedDriveInfo> GetListWitHCustominzedDriveInfo()
        {
            var drives = DriveInfo.GetDrives();
            List<CustomizedDriveInfo> ListOfCustomizedDriveInfo = new List<CustomizedDriveInfo>();
            foreach(var drive in drives)
            {
                drive.
            }
        }

    }
}
