using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using FreeSpace.Models;
using FreeSpace.HelperFunctions;
using System.Collections.Generic;

namespace FreeSpace.ViewModels;

partial class SelectFilesFoldersViewModel
{
    public List<CustomDriveInfo> Drives { get; }
    public SelectFilesFoldersViewModel()
    {
        Drives = GetDrivesHelper.GetAllDrives();
    }
    
}