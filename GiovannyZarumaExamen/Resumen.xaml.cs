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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario,string nombre, double primerAbono, double pagomensual)
        {
            InitializeComponent();
            double total;
            lblUser.Text =  usuario;
            lblNombre.Text = "Nombre Estudiante: " + nombre;
            lblAbono.Text = "Primer Abono: " + primerAbono;
            lblMensual.Text = "Pago Mensual: " + pagomensual;
            total = primerAbono + (pagomensual * 3);
            lblFinal.Text = "Pago Total: " + total;

        }

        private void btnSalir_Clicked(object sender, EventArgs e)
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Alerta!!", "Desea Salir?", "Si", "No");
                if (result)  await this.Navigation.PopAsync();
            });
        }
    }
}