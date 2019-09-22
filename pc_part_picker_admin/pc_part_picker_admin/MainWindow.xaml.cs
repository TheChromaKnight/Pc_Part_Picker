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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pc_part_picker_admin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Database db = new Database();


        }

        //Setting the second menu up and running after THIS button is toggled 
        private void BtnMenuMore_Checked(object sender, RoutedEventArgs e)
        {
            BtnMenuChipset.Visibility = Visibility.Visible;
            BtnMenuChipset.IsEnabled = true;

            BtnMenuCmos.Visibility = Visibility.Visible;
            BtnMenuCmos.IsEnabled = true;

            BtnMenuManufacturer.Visibility = Visibility.Visible;
            BtnMenuManufacturer.IsEnabled = true;

            BtnMenuMemType.Visibility = Visibility.Visible;
            BtnMenuMemType.IsEnabled = true;

            BtnMenuSizeType.Visibility = Visibility.Visible;
            BtnMenuSizeType.IsEnabled = true;

            BtnMenuSocket.Visibility = Visibility.Visible;
            BtnMenuSocket.IsEnabled = true;

            BtnMenuStorageConn.Visibility = Visibility.Visible;
            BtnMenuStorageConn.IsEnabled = true;

            BtnMenuStorageSize.Visibility = Visibility.Visible;
            BtnMenuStorageSize.IsEnabled = true;

            BtnMenuStorageType.Visibility = Visibility.Visible;
            BtnMenuStorageType.IsEnabled = true;

            BtnMenuVgaSlotType.Visibility = Visibility.Visible;
            BtnMenuVgaSlotType.IsEnabled = true;


        }

        private void BtnMenuMore_Unchecked(object sender, RoutedEventArgs e)
        {
            BtnMenuChipset.Visibility = Visibility.Hidden;
            BtnMenuChipset.IsEnabled = false;

            BtnMenuCmos.Visibility = Visibility.Hidden;
            BtnMenuCmos.IsEnabled = false;

            BtnMenuManufacturer.Visibility = Visibility.Hidden;
            BtnMenuManufacturer.IsEnabled = false;

            BtnMenuMemType.Visibility = Visibility.Hidden;
            BtnMenuMemType.IsEnabled = false;

            BtnMenuSizeType.Visibility = Visibility.Hidden;
            BtnMenuSizeType.IsEnabled = false;

            BtnMenuSocket.Visibility = Visibility.Hidden;
            BtnMenuSocket.IsEnabled = false;

            BtnMenuStorageConn.Visibility = Visibility.Hidden;
            BtnMenuStorageConn.IsEnabled = false;

            BtnMenuStorageSize.Visibility = Visibility.Hidden;
            BtnMenuStorageSize.IsEnabled = false;

            BtnMenuStorageType.Visibility = Visibility.Hidden;
            BtnMenuStorageType.IsEnabled = false;

            BtnMenuVgaSlotType.Visibility = Visibility.Hidden;
            BtnMenuVgaSlotType.IsEnabled = false;
        }


       
    }
}
