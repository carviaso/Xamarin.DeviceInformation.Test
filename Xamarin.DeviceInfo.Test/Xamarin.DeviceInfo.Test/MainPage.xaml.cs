using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace Xamarin.DeviceInformation.Test
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetDevicesInfo();
        }

        private void GetDevicesInfo()
        {
            var device = DeviceInfo.Model;
        }
    }
}
