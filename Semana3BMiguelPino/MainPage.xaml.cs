using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana3BMiguelPino
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text;
            string contrasena = txt_contraseña.Text;

            await Navigation.PushAsync(new viewDos(usuario,contrasena));
        }
    }
}
