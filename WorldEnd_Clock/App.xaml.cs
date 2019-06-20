using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WorldEnd_Clock
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTEyMDM1QDMxMzcyZTMxMmUzMGRJL1dDOXJubWJJamE5bnAwU0lKcEtFY2t4cWppMktNT3JFMTdubXZsN0E9");
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage())
            {
                BarTextColor = Color.Black
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        
    }
   

}

