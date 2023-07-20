using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proyecto_Final.UNIDADES
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class capacidad : ContentPage

    {


        double kl;
        double hl;
        double dal;
        double l;
        double dl;
        double cl;
        double ml;

        public capacidad()
        {
            InitializeComponent();
        }


        private async void Calcular()
        {
            l = Convert.ToDouble(txtl.Text);
            kl = l / 1000;
            hl = l / 100;
            dal = l * 10;

            dl = l * 10;
            cl = l * 100;
            ml = l * 1000;


            await DisplayAlert("RESULTADOS ",
                "Kl:" + kl + "\n"
                + "hl:" + hl + "\n"
                + "dal:" + dal + "\n"
                + "l:" + l + "\n"
                + "dl:" + dl + "\n"
                + "cl:" + cl + "\n"
               + "ml:" + ml + "\n"
               + "", "Continuar");


        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(txtl.Text))
            {
                Calcular();
            }
            else
            {
                DisplayAlert("ERROR", "INGRESE UNA CANTIDAD", "OK");
            }
        }



        private async void btnvolver_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new menu());
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}