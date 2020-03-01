using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;
using PrimeraAppForms.Pages;

namespace PrimeraAppForms.ViewModel
{
    class MenuPrincipalViewModel : BaseViewModel
    {
        public ICommand UbicacionComando
        {
            get
            {
                return new Command(() =>
                {
                    (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new UbicacionPage());//Cambio la pagina de detalle
                    (Application.Current.MainPage as MasterDetailPage).IsPresented = false;//Oculto el menu
                });
            }
        }

        public ICommand AcercaDeComando
        {
            get
            {
                return new Command(() =>
                {
                    (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new AcercaDePage());
                    (Application.Current.MainPage as MasterDetailPage).IsPresented = false;
                });
            }
        }

        public ICommand CamaraComando
        {
            get
            {
                return new Command(() =>
                {
                    (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new CamaraPage());
                    (Application.Current.MainPage as MasterDetailPage).IsPresented = false;
                }
                    );
            }
        }

        public ICommand DirectorioComando
        {
            get
            {
                return new Command(() =>
                {
                    (Application.Current.MainPage as MasterDetailPage).Detail = new NavigationPage(new DirectorioPage());
                    (Application.Current.MainPage as MasterDetailPage).IsPresented = false;
                }
                    );
            }
        }

        public ICommand SalirComando
        {
            get
            {
                return new Command(() =>
                {
                    TabbedPage pestañas = new TabbedPage();
                    pestañas.Children.Add(new Pages.IniciarSesionPage());
                    pestañas.Children.Add(new Pages.RegistroPage());
                    Application.Current.MainPage = new NavigationPage(pestañas);
                }
             );

            }
        }
    }
}
