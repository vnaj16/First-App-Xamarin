using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace PrimeraAppForms.ViewModel
{
    class UbicacionViewModel : BaseViewModel
    {
        public UbicacionViewModel()
        {
            Ubicar();
        }
        private double latitud;
        public double Latitud
        {
            get => latitud; set => SetProperty(ref latitud, value);
        }

        private double longitud;
        public double Longitud
        {
            get => longitud; set => SetProperty(ref longitud, value);
        }
        private string direccion;
        public string Direccion
        {
            get => direccion; set => SetProperty(ref direccion, value);
        }

        private async void Ubicar()
        {
            try
            {
                GeolocationRequest peticionUbicacion = new GeolocationRequest(GeolocationAccuracy.Best, TimeSpan.FromSeconds(5));
                var ubicacion = await Geolocation.GetLocationAsync(peticionUbicacion);
                Latitud = ubicacion.Latitude;
                Longitud = ubicacion.Longitude;
                var direccionActual = (await Geocoding.GetPlacemarksAsync(ubicacion)).First();
                Direccion = $"Calle {direccionActual.Thoroughfare} No.{direccionActual.SubThoroughfare}, Colonia {direccionActual.Locality}, C.P. {direccionActual.PostalCode}. {direccionActual.CountryName}";
            }
            catch (FeatureNotSupportedException fnsEx)
            {//Handlenotsupportedondeviceexception
            }
            catch (PermissionException pEx)
            {//Handlepermissionexception
            }
            catch (Exception ex)
            {//Unabletogetlocation}
            }
        }

    }
}
