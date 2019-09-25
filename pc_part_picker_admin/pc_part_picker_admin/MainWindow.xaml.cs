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
           
            BtnMenu2Chipset.Visibility = Visibility.Visible;
            BtnMenu2Chipset.IsEnabled = true;

            BtnMenu2ManufProcess.Visibility = Visibility.Visible;
            BtnMenu2ManufProcess.IsEnabled = true;

            BtnMenu2Manufacturer.Visibility = Visibility.Visible;
            BtnMenu2Manufacturer.IsEnabled = true;

            BtnMenu2MemType.Visibility = Visibility.Visible;
            BtnMenu2MemType.IsEnabled = true;

            BtnMenu2SizeType.Visibility = Visibility.Visible;
            BtnMenu2SizeType.IsEnabled = true;

            BtnMenu2Socket.Visibility = Visibility.Visible;
            BtnMenu2Socket.IsEnabled = true;

            BtnMenu2StorageConn.Visibility = Visibility.Visible;
            BtnMenu2StorageConn.IsEnabled = true;

            BtnMenu2StorageSize.Visibility = Visibility.Visible;
            BtnMenu2StorageSize.IsEnabled = true;

            BtnMenu2StorageType.Visibility = Visibility.Visible;
            BtnMenu2StorageType.IsEnabled = true;

            BtnMenu2VgaSlotType.Visibility = Visibility.Visible;
            BtnMenu2VgaSlotType.IsEnabled = true;


        }

        private void BtnMenuMore_Unchecked(object sender, RoutedEventArgs e)
        {
            BtnMenu2Chipset.IsChecked = false;
            BtnMenu2Manufacturer.IsChecked = false;
            BtnMenu2ManufProcess.IsChecked = false;
            BtnMenu2MemType.IsChecked = false;
            BtnMenu2SizeType.IsChecked = false;
            BtnMenu2Socket.IsChecked = false;
            BtnMenu2StorageConn.IsChecked = false;
            BtnMenu2StorageSize.IsChecked = false;
            BtnMenu2StorageType.IsChecked = false;
            BtnMenu2VgaSlotType.IsChecked = false;

            BtnMenu2Chipset.Visibility = Visibility.Hidden;
            BtnMenu2Chipset.IsEnabled = false;

            BtnMenu2ManufProcess.Visibility = Visibility.Hidden;
            BtnMenu2ManufProcess.IsEnabled = false;

            BtnMenu2Manufacturer.Visibility = Visibility.Hidden;
            BtnMenu2Manufacturer.IsEnabled = false;

            BtnMenu2MemType.Visibility = Visibility.Hidden;
            BtnMenu2MemType.IsEnabled = false;

            BtnMenu2SizeType.Visibility = Visibility.Hidden;
            BtnMenu2SizeType.IsEnabled = false;

            BtnMenu2Socket.Visibility = Visibility.Hidden;
            BtnMenu2Socket.IsEnabled = false;

            BtnMenu2StorageConn.Visibility = Visibility.Hidden;
            BtnMenu2StorageConn.IsEnabled = false;

            BtnMenu2StorageSize.Visibility = Visibility.Hidden;
            BtnMenu2StorageSize.IsEnabled = false;

            BtnMenu2StorageType.Visibility = Visibility.Hidden;
            BtnMenu2StorageType.IsEnabled = false;

            BtnMenu2VgaSlotType.Visibility = Visibility.Hidden;
            BtnMenu2VgaSlotType.IsEnabled = false;
        }

        private void BtnMenuCpu_Checked(object sender, RoutedEventArgs e)
        {
            //The grid must be invisible and MUST NOT have any sizes, because every other component has a (dynamic) fixed size 
            GridNewsFeed.Height = 0;
            GridNewsFeed.Visibility = Visibility.Hidden;
            GridNewsFeed.IsEnabled = false;
            GridNewsFeedText.Visibility = Visibility.Hidden;
            GridNewsFeedText.IsEnabled = false;
            GridNewsFeedText.Height = 0;

            BtnMenuMb.IsChecked = false;
            BtnMenuMemory.IsChecked = false;
            BtnMenuVga.IsChecked = false;
            BtnMenuStorage.IsChecked = false;
            BtnMenuCase.IsChecked = false;
            BtnMenuPsu.IsChecked = false;

            TblOpeningText.Text = "Cpu";

            TblWarning.Text = "";



            TbCpuBaseFreq.Visibility = Visibility.Visible;
            TbCpuBaseFreq.IsEnabled = true;

            TbCpuCore.Visibility = Visibility.Visible;
            TbCpuCore.IsEnabled = true;

            TbCpuL2Cache.Visibility = Visibility.Visible;
            TbCpuL2Cache.IsEnabled = true;

            TbCpuL3Cache.Visibility = Visibility.Visible;
            TbCpuL3Cache.IsEnabled = true;

            TbCpuMsrp.Visibility = Visibility.Visible;
            TbCpuMsrp.IsEnabled = true;

            TbCpuName.Visibility = Visibility.Visible;
            TbCpuName.IsEnabled = true;

            TbCpuTdp.Visibility = Visibility.Visible;
            TbCpuTdp.IsEnabled = true;

            TbCpuThread.Visibility = Visibility.Visible;
            TbCpuThread.IsEnabled = true;

            TbCpuTurboFreq.Visibility = Visibility.Visible;
            TbCpuTurboFreq.IsEnabled = true;

            TblCpuBaseFreq.Visibility = Visibility.Visible;
            TblCpuBaseFreq.IsEnabled = true;

            TblCpuBaseFreqMeasure.Visibility = Visibility.Visible;
            TblCpuBaseFreqMeasure.IsEnabled = true;

            TblCpuCore.Visibility = Visibility.Visible;
            TblCpuCore.IsEnabled = true;

            TblCpuIntegrVga.Visibility = Visibility.Visible;
            TblCpuIntegrVga.IsEnabled = true;

            TblCpuL2Cache.Visibility = Visibility.Visible;
            TblCpuL2Cache.IsEnabled = true;

            TblCpuL2CacheMeasure.Visibility = Visibility.Visible;
            TblCpuL2CacheMeasure.IsEnabled = true;

            TblCpuL3Cache.Visibility = Visibility.Visible;
            TblCpuL3Cache.IsEnabled = true;

            TblCpuL3CacheMeasure.Visibility = Visibility.Visible;
            TblCpuL3CacheMeasure.IsEnabled = true;

            TblCpuManufProcess.Visibility = Visibility.Visible;
            TblCpuManufProcess.IsEnabled = true;

            TblCpuMsrp.Visibility = Visibility.Visible;
            TblCpuMsrp.IsEnabled = true;

            TblCpuMsrpMeasure.Visibility = Visibility.Visible;
            TblCpuMsrpMeasure.IsEnabled = true;

            TblCpuName.Visibility = Visibility.Visible;
            TblCpuName.IsEnabled = true;

            TblCpuSocket.Visibility = Visibility.Visible;
            TblCpuSocket.IsEnabled = true;

            TblCpuTdp.Visibility = Visibility.Visible;
            TblCpuTdp.IsEnabled = true;

            TblCpuTdpMeasure.Visibility = Visibility.Visible;
            TblCpuTdpMeasure.IsEnabled = true;

            TblCpuThread.Visibility = Visibility.Visible;
            TblCpuThread.IsEnabled = true;

            TblCpuTurboFreq.Visibility = Visibility.Visible;
            TblCpuTurboFreq.IsEnabled = true;

            TblCpuTurboFreqMeasure.Visibility = Visibility.Visible;
            TblCpuTurboFreqMeasure.IsEnabled = true;

            TblCpuManufProcessMeasure.Visibility = Visibility.Visible;
            TblCpuManufProcessMeasure.IsEnabled = true;

            CbCpuManufProcess.Visibility = Visibility.Visible;
            CbCpuManufProcess.IsEnabled = true;

            CbCpuSocket.Visibility = Visibility.Visible;
            CbCpuSocket.IsEnabled = true;

            BtnCpuUpdate.Visibility = Visibility.Visible;
            BtnCpuUpdate.IsEnabled = true;

            BtnCpuUpload.Visibility = Visibility.Visible;
            BtnCpuUpload.IsEnabled = true;


        }

        private void BtnMenuCpu_Unchecked(object sender, RoutedEventArgs e)
        {
            //Restoring the grid's size
            GridNewsFeed.Height = 300;
            GridNewsFeed.Visibility = Visibility.Visible;
            GridNewsFeed.IsEnabled = true;
            GridNewsFeedText.Visibility = Visibility.Visible;
            GridNewsFeedText.IsEnabled = true;
            GridNewsFeedText.Height = 22;

            TblOpeningText.Text = "News";




            TbCpuBaseFreq.Visibility = Visibility.Hidden;
            TbCpuBaseFreq.IsEnabled = false;

            TbCpuCore.Visibility = Visibility.Hidden;
            TbCpuCore.IsEnabled = false;

            TbCpuL2Cache.Visibility = Visibility.Hidden;
            TbCpuL2Cache.IsEnabled = false;

            TbCpuL3Cache.Visibility = Visibility.Hidden;
            TbCpuL3Cache.IsEnabled = false;

            TbCpuMsrp.Visibility = Visibility.Hidden;
            TbCpuMsrp.IsEnabled = false;

            TbCpuName.Visibility = Visibility.Hidden;
            TbCpuName.IsEnabled = false;

            TbCpuTdp.Visibility = Visibility.Hidden;
            TbCpuTdp.IsEnabled = false;

            TbCpuThread.Visibility = Visibility.Hidden;
            TbCpuThread.IsEnabled = false;

            TbCpuTurboFreq.Visibility = Visibility.Hidden;
            TbCpuTurboFreq.IsEnabled = false;

            TblCpuBaseFreq.Visibility = Visibility.Hidden;
            TblCpuBaseFreq.IsEnabled = false;

            TblCpuBaseFreqMeasure.Visibility = Visibility.Hidden;
            TblCpuBaseFreqMeasure.IsEnabled = false;

            TblCpuCore.Visibility = Visibility.Hidden;
            TblCpuCore.IsEnabled = false;

            TblCpuIntegrVga.Visibility = Visibility.Hidden;
            TblCpuIntegrVga.IsEnabled = false;

            TblCpuL2Cache.Visibility = Visibility.Hidden;
            TblCpuL2Cache.IsEnabled = false;

            TblCpuL2CacheMeasure.Visibility = Visibility.Hidden;
            TblCpuL2CacheMeasure.IsEnabled = false;

            TblCpuL3Cache.Visibility = Visibility.Hidden;
            TblCpuL3Cache.IsEnabled = false;

            TblCpuL3CacheMeasure.Visibility = Visibility.Hidden;
            TblCpuL3CacheMeasure.IsEnabled = false;

            TblCpuManufProcess.Visibility = Visibility.Hidden;
            TblCpuManufProcess.IsEnabled = false;

            TblCpuMsrp.Visibility = Visibility.Hidden;
            TblCpuMsrp.IsEnabled = false;

            TblCpuMsrpMeasure.Visibility = Visibility.Hidden;
            TblCpuMsrpMeasure.IsEnabled = false;

            TblCpuName.Visibility = Visibility.Hidden;
            TblCpuName.IsEnabled = false;

            TblCpuSocket.Visibility = Visibility.Hidden;
            TblCpuSocket.IsEnabled = false;

            TblCpuTdp.Visibility = Visibility.Hidden;
            TblCpuTdp.IsEnabled = false;

            TblCpuTdpMeasure.Visibility = Visibility.Hidden;
            TblCpuTdpMeasure.IsEnabled = false;

            TblCpuThread.Visibility = Visibility.Hidden;
            TblCpuThread.IsEnabled = false;

            TblCpuTurboFreq.Visibility = Visibility.Hidden;
            TblCpuTurboFreq.IsEnabled = false;

            TblCpuTurboFreqMeasure.Visibility = Visibility.Hidden;
            TblCpuTurboFreqMeasure.IsEnabled = false;

            TblCpuManufProcessMeasure.Visibility = Visibility.Hidden;
            TblCpuManufProcessMeasure.IsEnabled = false;

            CbCpuManufProcess.Visibility = Visibility.Hidden;
            CbCpuManufProcess.IsEnabled = false;

            CbCpuSocket.Visibility = Visibility.Hidden;
            CbCpuSocket.IsEnabled = false;

            BtnCpuUpdate.Visibility = Visibility.Hidden;
            BtnCpuUpdate.IsEnabled = false;

            BtnCpuUpload.Visibility = Visibility.Hidden;
            BtnCpuUpload.IsEnabled = false;
        }

    }
}
