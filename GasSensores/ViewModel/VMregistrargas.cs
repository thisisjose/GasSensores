using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GasSensores.ViewModel
{
    public class VMregistrargas : BaseViewModel
    {
        #region
      
        #endregion

        #region Contructor
        public VMregistrargas(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;



        #endregion
        #region PROCESOS
        public async Task Insertar()
        {

            await MostrarAlerta("Nota guardada correctamente", "OK");
            await Volver();
        }

        private async Task MostrarAlerta(string mensaje, string botonOK)
        {
            await Application.Current.MainPage.DisplayAlert("Éxito", mensaje, botonOK);
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        #endregion.

        #region CONTRUCTOR
        #endregion.

        #region COMANDOS
        public ICommand Insertarcommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        #endregion
    }
}
