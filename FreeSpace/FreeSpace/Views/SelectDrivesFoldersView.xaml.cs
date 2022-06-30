using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using FreeSpace.ViewModels;
using CommunityToolkit.Mvvm;

namespace FreeSpace.Views
{
    /// <summary>
    /// Interaction logic for SelectDrivesFoldersView.xaml
    /// </summary>
    public partial class SelectDrivesFoldersView : Window
    {
        public SelectDrivesFoldersView()
        {
            InitializeComponent();
            DataContext = new SelectFilesFoldersViewModel();
        }
        
        public void OnClose(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
