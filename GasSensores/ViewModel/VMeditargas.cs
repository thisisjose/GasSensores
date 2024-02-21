﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GasSensores.ViewModel
{
    public class VMeditargas : BaseViewModel
    {
        #region VARIABLES

        
        #endregion
        #region Contructor
        public VMeditargas(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetivo;


        #endregion
        #region PROCESOS

        public async Task Editar()
        {

            await Volver();
            await MostrarAlerta("Nota editada correctamente", "OK");

        }
        private async Task MostrarAlerta(string mensaje, string botonOK)
        {
            await Application.Current.MainPage.DisplayAlert("Éxito", mensaje, botonOK);
        }

        public async Task Eliminar()
        {


            await Volver();
            await MostrarAlerta("Nota Eliminada correctamente", "OK");

        }

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }


        #endregion.
        #region CONTRUCTOR

        #endregion.
        #region COMANDOS
        public ICommand Editarcommand => new Command(async () => await Editar());
        public ICommand Eliminarcommand => new Command(async () => await Eliminar());

        public ICommand Volvercommand => new Command(async () => await Volver());

        #endregion

    }
}
