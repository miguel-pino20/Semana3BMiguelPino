using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana3BMiguelPino
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario,string contrasena)
        {
            InitializeComponent();
            //envio a los label
            lbusuario.Text = usuario;
            lbcontraseña.Text = contrasena;
            //cajas de texto
            txtUsuario.Text = usuario;
            txtContrasena.Text = contrasena;
        }

        
    }
}