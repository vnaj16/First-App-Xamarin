using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace PrimeraAppForms.ViewModel
{
    class AcercaDeViewModel : BaseViewModel
    {
        public AcercaDeViewModel()
        {
            Inicializar();
        }
        void Inicializar()
        {
            try
            {
                Version = AppInfo.VersionString;
                NombreDispositivo = DeviceInfo.Name;
                VersionSO = DeviceInfo.Version.ToString();
                FabricanteDispositivo = DeviceInfo.Manufacturer;
                ModeloDispositivo = DeviceInfo.Model;
            }
            catch (Exception ex) { }
        }

        private string nombreDispositivo;

        public string NombreDispositivo
        {
            get => nombreDispositivo;
            set => SetProperty(ref nombreDispositivo, value);
        }

        private string version;

        public string Version
        {
            get => version;
            set => SetProperty(ref version, value);
        }

        private string fabricanteDispositivo;

        public string FabricanteDispositivo
        {
            get => fabricanteDispositivo;
            set => SetProperty(ref fabricanteDispositivo, value);
        }
        private string modeloDispositivo;
        public string ModeloDispositivo
        {
            get => modeloDispositivo;
            set => SetProperty(ref modeloDispositivo, value);
        }
        private string versionSO;
        public string VersionSO
        {
            get => versionSO;
            set => SetProperty(ref versionSO, value);
        }
    }
}
