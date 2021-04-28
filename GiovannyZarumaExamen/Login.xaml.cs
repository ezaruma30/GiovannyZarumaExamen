using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GiovannyZarumaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Boton Ingreso de Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string clave = txtPass.Text;

            if ((usuario == "estudiante2021") && (clave == "uisrael2021"))
            {
                await Navigation.PushAsync(new Registro(usuario, clave));
            }
            else
            {
                lblResultado.Text = "El usuario o contraseña es incorrecto";
            }
        }
    }
}