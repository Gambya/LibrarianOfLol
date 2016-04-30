﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibrarianOfLol.Views;
using Xamarin.Forms;

namespace LibrarianOfLol
{
    public class App : Application
    {
        private NavigationPage _selectPage;
        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new LoginPage());
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
