﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace steventExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciarLogin_Clicked(object sender, EventArgs e)
        {

            string usuario = "estudiante2023";
            string clave = "uisrael2023";

            if (txtUsuario.Text == usuario && txtClave.Text == clave)
            {

                Navigation.PushAsync(new Registro(usuario));

            }
            else
            {

                DisplayAlert("Alerta", "Datos Incorrectos", "cerrar");
            }

        }
    }


}