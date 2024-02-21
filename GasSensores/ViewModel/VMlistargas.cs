using GasSensores.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GasSensores.ViewModel
{
    public class VMlistargas : BaseViewModel
    {
        #region VARIABLES


        #endregion

        public VMlistargas(INavigation navigation)
        {
            Navigation = navigation;
        }

        #region PROCESOS

        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new RegistrarSensor());
        }
        //public async Task IraEditar(Mnotas Pokemon)
        //{
        //    await Navigation.PushAsync(new EditarNota(Pokemon));
        //}

        #endregion.

        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        #endregion

    }
}
