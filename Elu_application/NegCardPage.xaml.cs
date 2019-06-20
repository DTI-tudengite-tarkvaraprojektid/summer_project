﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Elu_application
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

                    ddlCards.Text += "Kategooria : " + (item.Kategooria) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Mõju : " + (item.Loodusvarad) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Nimetus : " + (item.Nimetus) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Elustik : " + (item.Elustik) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Turism : " + (item.Turism) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Rahulolu : " + (item.Rahuolu) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Üldine skoor : " + (item.Skoor) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Kirjeldus : " + (item.Kirjeldus) + "\n";

                }
            }
        }
    }
}
