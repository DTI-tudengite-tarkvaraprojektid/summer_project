using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorldEnd_Clock
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int i = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Inc_Click(object sender, EventArgs e)
        {
            i += 1;
            pointer.Value = Convert.ToDouble(i);
            if (pointer.Value == 25)
            {
                DisplayAlert("Alert", "Value is 25!", "OK");
            }
            if (pointer.Value == 50)
            {
                DisplayAlert("Alert", "Value is 50!", "OK");
            }
            if (pointer.Value == 75)
            {
                DisplayAlert("Alert", "Value is 75!", "OK");
            }
            if (pointer.Value == 100)
            {
                DisplayAlert("Alert", "Value is 100!", "OK");
            }
        }
        private void Dec_Click(object sender, EventArgs e)
        {
            i -= 1;
            pointer.Value = Convert.ToDouble(i);
            if (pointer.Value == 25)
            {
                DisplayAlert("Alert", "Value is 25!", "OK");
            }
            if (pointer.Value == 50)
            {
                DisplayAlert("Alert", "Value is 50!", "OK");
            }
            if (pointer.Value == 75)
            {
                DisplayAlert("Alert", "Value is 75!", "OK");
            }
            if (pointer.Value == 100)
            {
                DisplayAlert("Alert", "Value is 100!", "OK");
            }
        }

        
    }
}
