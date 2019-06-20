using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace WorldEnd_Clock
{
    public partial class ScannedCardPage : ContentPage
    {
        private string result;
        private double sum = 0;
        public ScannedCardPage(string QrCodeResult)
        {
            InitializeComponent();
            result = QrCodeResult;

        }



        protected override void OnAppearing()
        {

            base.OnAppearing();
            DatabaseManager databasemanager = new DatabaseManager();
            var cards = databasemanager.GetAllMainCards();

            foreach (var item in cards)
            {
                if (item.UniKood == result)
                {
                    ddlCards.Text += (item.Id) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Kategooria) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Loodusvarad) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Nimetus) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Elustik) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Turism) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Rahuolu) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Skoor) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += (item.Kirjeldus) + "\n";

                    MainPage.CalculateScore(Convert.ToInt32(item.Skoor));

                }
            }
        }
    }
}