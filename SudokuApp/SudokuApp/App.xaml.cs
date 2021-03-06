﻿using System;
using SudokuApp.Model;
using SudokuApp.view;
using SudokuApp.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SudokuApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage(new MainPageViewModel(new SudokuManager()));
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
