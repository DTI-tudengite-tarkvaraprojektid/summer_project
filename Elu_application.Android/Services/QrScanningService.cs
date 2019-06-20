using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Elu_application.Service;
using ZXing.Mobile;
using Xamarin.Forms;

[assembly: Dependency(typeof(WorldEnd_Clock.Droid.Service.QrScanningService))]

namespace WorldEnd_Clock.Droid.Service
{
    public class QrScanningService : IQrScanningService
    {
        public async Task<string> ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            if (scanResult == null)
            {
                return "";
            }
            else
            {
                return scanResult.Text;
            }
        }
    }
}