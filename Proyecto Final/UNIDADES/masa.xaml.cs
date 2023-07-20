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
    public partial class masa : ContentPage
    {


        double kg;
        double hg;
        double dag;
        double g;
        double dg;
        double cg;
        double mg;


        public masa()
        {
            InitializeComponent();
        }

        private async void Calcular()
        {
            g = Convert.ToDouble(txtg.Text);
            kg = g / 1000;
            hg = g / 100;
            dag = g * 10;

            dg = g * 10;
            cg = g * 100;
            mg = g * 1000;


            await DisplayAlert("RESULTADOS ",
                "Kg:" + kg + "\n"
                + "hg:" + hg + "\n"
                + "dag:" + dag + "\n"
                + "g:" + g + "\n"
                + "dg:" + dg + "\n"
                + "cg:" + cg + "\n"
               + "mg:" + mg + "\n"
               + "", "Continuar");


        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(txtg.Text))
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