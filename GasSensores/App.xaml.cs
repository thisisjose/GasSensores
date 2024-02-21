using GasSensores.View;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GasSensores
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListarGas());
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
