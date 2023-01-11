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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, string nombre, double total)
        {
            InitializeComponent();
            lblUsuarioS.Text = usuario;
            txtNombreS.Text = nombre;
            txtTotalS.Text = total.ToString();
        }

        private void btnInfo_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Información", "Steven Tituaña Coyago", "Ok");
        }
    }
}