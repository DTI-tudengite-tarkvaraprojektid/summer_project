using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using WorldEnd_Clock.Service;

namespace WorldEnd_Clock
{

    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int i = 100;
        int currentRoll = 0;
        int negCounter = 0;
        int posCounter = 0;
        int checkDivide;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Change_Pointer_Value(double pointerValue)
        {
            checkDivide = Convert.ToInt32(pointerValue);
            if (checkDivide % 5 == 0 && 0 < checkDivide  && checkDivide < 100)
            {
                DisplayAlert("Alert", "Dividable!", "OK");
            }
            if (pointer.Value >= 100)
            {
                i = 100;
                pointer.Value = 100;
            }
            if (pointer.Value == 50)
            {
                DisplayAlert("Alert", "Value is 50!", "OK");
            }
            if (pointer.Value == 100)
            {
                DisplayAlert("Alert", "Value is 100!", "OK");
            }
            if(pointer.Value <= 0)
            {
                i = 0;
                pointer.Value = 0;
                DisplayAlert("Alert", "Game over!", "OK");
                i = 100;
                pointer.Value = 100;
                posCounter = negCounter = 0;
                labelPos.Text = labelNeg.Text = "";
            }
        }

        private void Inc_Click(object sender, EventArgs e)
        {
            if (i < 100)
            {
                posCounter++;
                labelPos.Text = "+" + Convert.ToString(posCounter);
            }
            i++;
            pointer.Value = Convert.ToDouble(i);
            Change_Pointer_Value(pointer.Value);
        }
        private void Dec_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                negCounter++;
                labelNeg.Text = "-" + Convert.ToString(negCounter);
            }
            i--;
            pointer.Value = Convert.ToDouble(i);
            Change_Pointer_Value(pointer.Value);
        }
        private void Roll(object sender, System.EventArgs e)
        {
            RollDice();
        }


        private void RollDice()
        {
            Random roll = new Random();
            currentRoll = roll.Next(1, 7);
            diceLabel.Text = String.Format("You rolled " + currentRoll + " !");
            diceLabel.TextColor = Color.Black;
            //images are in drawable folder in resources
            switch (currentRoll)
            {
                case 1:
                    diceImage.Source = "dice1.png";
                    break;
                case 2:
                    diceImage.Source = "dice2.png";
                    break;
                case 3:
                    diceImage.Source = "dice3.png";
                    break;
                case 4:
                    diceImage.Source = "dice4.png";
                    break;
                case 5:
                    diceImage.Source = "dice5.png";
                    break;
                case 6:
                    diceImage.Source = "dice6.png";
                    break;
                case 0:
                    diceImage.Source = "dice1.png";
                    break;
            }
        }
        private void Scan(object sender, System.EventArgs e)
        {
            ScanQR();
        }

        private async void ScanQR()
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
