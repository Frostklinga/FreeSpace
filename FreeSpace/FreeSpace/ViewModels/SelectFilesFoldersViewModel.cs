using System.Collections.Generic;
using System.IO;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

using System.Windows.Forms;

using FreeSpace.Models;
using FreeSpace.HelperFunctions;

namespace FreeSpace.ViewModels
{

    [INotifyPropertyChanged]
    public partial class SelectFilesFoldersViewModel
    {
        public List<CustomDriveInfo> Drives { get; }
        //OpenFileDialog SelectDirectoryDialog;

        public FolderDriveSectionSelected EnableFoldersDrivesSection { get; private set; } = FolderDriveSectionSelected.Drives;
        public SelectFilesFoldersViewModel()
        {
            Drives = GetDrivesHelper.GetAllDrives();

            //PickAFolderCommandCommand.Execute(true);
        }
        public void ProcessDriveOrFolderSelection()
        {

        }
        public void ProcessSelectionChangedCommand()
        {

        }
        public void AllLocalDrivesSelectedCommand()
        {

        }
        public void IndividualDrivesSelectedCommand()
        {

        }
        [RelayCommand]
        public void SelectFolderCommand()
        {

        }
        public string ?FolderPath { get; private set; }
        //TODO: Find a replacement for the windows form folder dialog.
        [RelayCommand]
        public void PickAFolderCommand()
        {
            using var fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {
                FolderPath = fbd.SelectedPath;
            }
        }
    }
    public enum FolderDriveSectionSelected
    {
        Drives,
        Folders
    }
}