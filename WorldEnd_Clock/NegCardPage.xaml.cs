﻿using System;
using System.Collections.Generic;
using WorldEnd_Clock;
using Xamarin.Forms;

namespace WorldEnd_Clock
{
    public partial class NegCardPage : ContentPage
    {
        public NegCardPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DatabaseManager databasemanager = new DatabaseManager();
            var cards = databasemanager.GetAllNegativeCards();
            Random card = new Random();
            var currentCardId = card.Next(0, 24);//negative 1 -- 23 //positive 24 -- 47 

            foreach (var item in cards)
            {
                if (Convert.ToInt32(item.Id) == currentCardId && item.UniKood.Substring(0, 4) == "#NEG")
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