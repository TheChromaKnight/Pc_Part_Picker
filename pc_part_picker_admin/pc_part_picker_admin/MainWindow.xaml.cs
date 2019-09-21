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
        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            btnChipset.Visibility = Visibility.Visible;
            btnChipset.IsEnabled = true;

            btnCmos.Visibility = Visibility.Visible;
            btnCmos.IsEnabled = true;

            btnManufacturer.Visibility = Visibility.Visible;
            btnManufacturer.IsEnabled = true;

            btnMemType.Visibility = Visibility.Visible;
            btnMemType.IsEnabled = true;

            btnSizeType.Visibility = Visibility.Visible;
            btnSizeType.IsEnabled = true;

            btnSocket.Visibility = Visibility.Visible;
            btnSocket.IsEnabled = true;

            btnStorageConn.Visibility = Visibility.Visible;
            btnStorageConn.IsEnabled = true;

            btnStorageSize.Visibility = Visibility.Visible;
            btnStorageSize.IsEnabled = true;

            btnStorageType.Visibility = Visibility.Visible;
            btnStorageType.IsEnabled = true;

            btnVgaSlotType.Visibility = Visibility.Visible;
            btnVgaSlotType.IsEnabled = true;


        }

        private void btnMore_Unchecked(object sender, RoutedEventArgs e)
        {
            btnChipset.Visibility = Visibility.Hidden;
            btnChipset.IsEnabled = false;

            btnCmos.Visibility = Visibility.Hidden;
            btnCmos.IsEnabled = false;

            btnManufacturer.Visibility = Visibility.Hidden;
            btnManufacturer.IsEnabled = false;

            btnMemType.Visibility = Visibility.Hidden;
            btnMemType.IsEnabled = false;

            btnSizeType.Visibility = Visibility.Hidden;
            btnSizeType.IsEnabled = false;

            btnSocket.Visibility = Visibility.Hidden;
            btnSocket.IsEnabled = false;

            btnStorageConn.Visibility = Visibility.Hidden;
            btnStorageConn.IsEnabled = false;

            btnStorageSize.Visibility = Visibility.Hidden;
            btnStorageSize.IsEnabled = false;

            btnStorageType.Visibility = Visibility.Hidden;
            btnStorageType.IsEnabled = false;

            btnVgaSlotType.Visibility = Visibility.Hidden;
            btnVgaSlotType.IsEnabled = false;
        }
    }
}
