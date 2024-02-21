using GasSensores.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GasSensores.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarGas : ContentPage
    {
        VMlistargas vM;
        public ListarGas()
        {
            InitializeComponent();
            vM = new VMlistargas(Navigation);

            BindingContext = vM;

        }
    }
}