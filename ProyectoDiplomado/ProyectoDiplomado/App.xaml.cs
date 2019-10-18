﻿using ProyectoDiplomado.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace ProyectoDiplomado
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
          //   MainPage = new NavigationPage(new NavigationPageView());
             MainPage = new Pages.MarteDetailPageMainView();
          //  MainPage = new NavigationPage(new Views.ProductView());
            //   MainPage = new CarusePageView();
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
