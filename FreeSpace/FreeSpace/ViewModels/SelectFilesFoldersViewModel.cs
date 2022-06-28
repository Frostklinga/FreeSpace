using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using FreeSpace.Models;
namespace FreeSpace.ViewModels
{
    [INotifyPropertyChanged]
    partial class SelectFilesFoldersViewModel
    {
        public SelectFilesFoldersViewModel()
        {
            CustomDriveInfo customDriveInfo = new CustomDriveInfo();
        }
        
    }
}