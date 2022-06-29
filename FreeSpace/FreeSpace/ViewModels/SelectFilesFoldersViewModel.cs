using System.Collections.Generic;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using FreeSpace.Models;
using FreeSpace.HelperFunctions;

namespace FreeSpace.ViewModels
{
    [INotifyPropertyChanged]
    public partial class SelectFilesFoldersViewModel
    {
        public List<CustomDriveInfo> Drives { get; }
        public SelectFilesFoldersViewModel()
        {
            Drives = GetDrivesHelper.GetAllDrives();
        }
    }
}