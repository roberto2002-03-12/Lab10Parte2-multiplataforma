using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab10Parte2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ListViewDemo();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
