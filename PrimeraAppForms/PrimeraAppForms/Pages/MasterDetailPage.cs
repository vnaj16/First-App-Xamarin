using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace PrimeraAppForms.Pages
{
    public class MasterDetail : MasterDetailPage
    {
        public MasterDetail()
        {
            Master = new NavigationPage( new MenuPrincipalPage()) { Title = "Menú" };
            Detail = new NavigationPage( new UbicacionPage()) { Title = "Ubicación" };
        }
    }
}