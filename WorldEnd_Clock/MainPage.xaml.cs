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
        int currentRoll = 0;
        int checkDivide;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Inc_Click(object sender, EventArgs e)
        {
            i += 1;
            pointer.Value = Convert.ToDouble(i);
            checkDivide = Convert.ToInt32(pointer.Value);
            if (checkDivide % 5 == 0 && checkDivide != 0)
            {
                DisplayAlert("Alert", "Dividable!", "OK");
            }
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
            checkDivide = Convert.ToInt32(pointer.Value);
            if (checkDivide % 5 == 0 && checkDivide != 0)
            {
                DisplayAlert("Alert", "Dividable!", "OK");
            }
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


    }
}
