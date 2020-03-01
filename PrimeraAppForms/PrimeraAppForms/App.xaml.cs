using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PrimeraAppForms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();


            TabbedPage pestañas = new TabbedPage(); 
            pestañas.Children.Add(new Pages.IniciarSesionPage()); 
            pestañas.Children.Add(new Pages.RegistroPage()); 
            MainPage = new NavigationPage(pestañas);
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
