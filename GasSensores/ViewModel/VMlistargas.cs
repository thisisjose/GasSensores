﻿using GasSensores.View;
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
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        public ICommand IrAEditarCommand => new Command(async () => await IrAEditar());

        public VMlistargas(INavigation navigation)
        {
            Navigation = navigation;
        }

        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new RegistrarSensor());
        }

        public async Task IrAEditar()
        {
            await Navigation.PushAsync(new EditarGas());
        }

    }
}
