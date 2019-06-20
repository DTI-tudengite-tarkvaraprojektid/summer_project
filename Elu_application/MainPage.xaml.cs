using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.IO;
using Firebase.Database;
using System.Data.SqlClient;
using Elu_application.Service;

namespace Elu_application
{

    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        int currentRoll = 0;
        int negCounter = 0;
        int posCounter = 0;
        int checkDivide;
        int negPosCheck = 0;
        int i = 100;
        int timesPicked = 0;
        
        public MainPage()
        {
            InitializeComponent();

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    Padding = new Thickness(0, 20, 0, 0);
                    break;
                case Device.Android:
                    Padding = new Thickness(10, 20, 0, 0);
                    break;
                default:
                    Padding = new Thickness(0, 0, 0, 0);
                    break;
            }



        }

        //changing the pointer value accordingly
        private void Change_Pointer_Value(double pointerValue)
        {
            checkDivide = Convert.ToInt32(pointerValue);
            if (checkDivide % 5 == 0 && 0 <= checkDivide && checkDivide <= 100)
            {
                if(checkDivide > negPosCheck)
                {
                    if(timesPicked <= 2)
                    {
                        Navigation.PushAsync(new PosCardPage());
                    }
                    else
                    {
                        DisplayAlert("Kaardid", "Võetud rohkem kui kaks korda", "OK");
                    }

                }
                else
                {
                    if(timesPicked <= 2)
                    {
                        Navigation.PushAsync(new NegCardPage());
                    }
                    else
                    {
                        DisplayAlert("Kaardid", "Võetud rohkem kui kaks korda", "OK");
                    }
                }

            }
            if (pointer.Value >= 100)
            {

                i = 100 ;
                pointer.Value = 100;
            }
            if (pointer.Value <= 0)
            {
                i = 0;
                pointer.Value = 0;
                DisplayAlert("Alert", "Game over!", "OK");
                i = 100;
                pointer.Value = 100;
                posCounter = negCounter = 0;
                labelPos.Text = labelNeg.Text = "";

            }//calculated score is from the card that was scanned by the qr code

        }
        //Increases the clock
        private void Inc_Click(object sender, EventArgs e)
        {
            negPosCheck = Convert.ToInt32(pointer.Value);
            if (i < 100)
            {
                posCounter++;
                labelPos.Text = "+" + Convert.ToString(posCounter);
            }
            i++;
            pointer.Value = Convert.ToDouble(i);
            Change_Pointer_Value(pointer.Value);
        }

        //decreases the clock
        private void Dec_Click(object sender, EventArgs e)
        {
            negPosCheck = Convert.ToInt32(pointer.Value);
            if (i > 0)
            {
                negCounter++;
                labelNeg.Text = "-" + Convert.ToString(negCounter);
            }
            i--;
            pointer.Value = Convert.ToDouble(i);
            Change_Pointer_Value(pointer.Value);
        }

        //starts the roll function
        private void Roll(object sender, System.EventArgs e)
        {
            RollDice();
        }

        //function that makes the dice images change randomly
        private void RollDice()
        {
            Random roll = new Random();
            currentRoll = roll.Next(1, 7);
            diceLabel.Text = System.String.Format("You rolled " + currentRoll + " !");
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
                default:
                    diceImage.Source = "dice1.png";
                    break;
            }

        }

        //starts the qrScanner
        private void Scan(object sender, System.EventArgs e)
        {
            ScanQR();
        }

        //QrCode scanner
        private async void ScanQR()
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    await Navigation.PushAsync(new ScannedCardPage(result));

                }
                else
                {
                    result = "";
                }
            }
            catch (Exception ex)
            {

                throw;
            }


        }

        //calculates the score and gets the parameter from the ScannedCardPage


    }
}
