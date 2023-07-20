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
    public partial class volumen : ContentPage
    {

        double km;
        double hm;
        double dam;
        double m;
        double dm;
        double cm;
        double mm;

       

        public volumen()
        {
            InitializeComponent();
        }

        private async void Calcular()
        {
            m = Convert.ToDouble(txtm.Text);
            km = m / 1000000;
            hm = m / 100000;
            dam = m/1000;

            dm = m * 1000;
            cm = m * 100000;
            mm = m * 1000000;


            await DisplayAlert("RESULTADOS ",
                "Km³:" + km + "\n"
                + "hm³:" + hm + "\n"
                + "dam³:" + dam + "\n"
                + "m³:" + m + "\n"
                + "dm³:" + dm + "\n"
                + "cm³:" + cm + "\n"
               + "mm³:" + mm + "\n"
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