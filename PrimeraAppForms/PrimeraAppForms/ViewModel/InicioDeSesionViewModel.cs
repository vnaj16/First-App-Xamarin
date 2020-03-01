using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using MvvmHelpers;
using Xamarin.Forms;

namespace PrimeraAppForms.ViewModel
{
    class InicioDeSesionViewModel : BaseViewModel
    {
        public ICommand IniciarComando
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new Pages.MasterDetail();
                });

            }
        }

    }
}
