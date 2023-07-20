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
    public partial class superficie : ContentPage
    {
        double km;
        double hm;
        double dam;
        double m;
        double dm;
        double cm;
        double mm;



        public superficie()
        {
            InitializeComponent();
        }


        private async void Calcular()
        {
            m = Convert.ToDouble(txtm.Text);
            km = m / 1000;
            hm = m / 100;
            dam = m * 10;

            dm = m * 10;
            cm = m * 100;
            mm = m * 1000;


            await DisplayAlert("RESULTADOS ",
                "Km²:" + km + "\n"
                + "hm²:" + hm + "\n"
                + "dam²:" + dam + "\n"
                + "m²:" + m + "\n"
                + "dm²:" + dm + "\n"
                + "cm²:" + cm + "\n"
               + "mm²:" + mm + "\n"
               + "", "Continuar");


        }
        private void validar()
        {
            if (!string.IsNullOrEmpty(txtm.Text))
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