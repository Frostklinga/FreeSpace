using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FreeSpace.Models;

namespace FreeSpace.HelperFunctions;

public static class GetDrivesHelper
{
    public static List<CustomDriveInfo> GetAllDrives()
    {
        var customDriveInfoList = new List<CustomDriveInfo>();
        foreach (var drive in DriveInfo.GetDrives())
        {
            var customDriveInfo = new CustomDriveInfo(drive);
            customDriveInfoList.Add(customDriveInfo);
        }
        return customDriveInfoList;
    }
}
