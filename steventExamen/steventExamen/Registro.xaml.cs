using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace steventExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnPagoM_Clicked(object sender, EventArgs e)
        {
            double monto_inicial = Convert.ToDouble(txtMontoInicial.Text);


            double pago_mensual = ((4000 - monto_inicial) / 5) + (4000 * 0.05);

            txtPagoMensual.Text = pago_mensual.ToString();
        }

        private void btnGuardarInfo_Clicked(object sender, EventArgs e)
        {
            double pago_mensual = Convert.ToDouble(txtPagoMensual.Text);
            double monto_inicial = Convert.ToDouble(txtMontoInicial.Text);
            double total = (pago_mensual * 5) + monto_inicial;
            string nombre = txtNombre.Text;

            DisplayAlert("Alerta", "Elemento guardado con exito", "ok");

            Navigation.PushAsync(new Resumen(lblUsuario.Text, nombre, total));
        }

        private void txtMontoInicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double monto_ini = Convert.ToDouble(txtMontoInicial.Text);

                if (monto_ini >= 4000)
                {
                    DisplayAlert("Validación", "Íngrese Cantidad Menor a 4000", "cerrar");
                    txtMontoInicial.Text = "".ToString();
                }
                else if (monto_ini < 0)
                {
                    DisplayAlert("Validación", "Íngrese Cantidad Mayor a 0", "cerrar");
                    txtMontoInicial.Text = "".ToString();
                }



            }
            catch
            {

            }
        }
    }
}