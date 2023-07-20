using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Proyecto_Final
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



       

        private async void btn_entrar_Clicked(object sender, EventArgs e)
        {
            String user = usuario.Text;
            int pass = Convert.ToInt32(password.Text);



            if (pass == 1234)
            {

                await DisplayAlert("AUTENTICACION", "Bienvenido " + user + "registo exitoso", "Continuar");

                await Application.Current.MainPage.Navigation.PushModalAsync(new menu());


            }
            else
            {

                await DisplayAlert("AUTENTICACION", user + "contrasena incorrecta", "Aceptar");
            }

        }


    }

}
 