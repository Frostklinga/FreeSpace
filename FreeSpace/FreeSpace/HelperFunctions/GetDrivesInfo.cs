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
        public static List<CustomDriveInfo> GetListWithCustominzedDriveInfo()
        {
            var drives = DriveInfo.GetDrives();
            List<CustomDriveInfo> ListOfCustomDriveInfo = new List<CustomDriveInfo>();
            foreach(var drive in drives)
            {
                CustomDriveInfo customDriveInfo = new CustomDriveInfo(drive);
                ListOfCustomDriveInfo.Add(customDriveInfo);
            }
            return ListOfCustomDriveInfo;
        }
    }
}