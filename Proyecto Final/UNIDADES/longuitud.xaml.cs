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
    public partial class longuitud : ContentPage
    {

        double km;
        double hm;
        double dam;
        double m;
        double dm;
        double cm;
        double mm;

        public longuitud()
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
                "Km:" +km+ "\n"
                +"hm:" +hm+ "\n" 
                + "dam:"+dam + "\n" 
                + "m:"+m+ "\n"
                + "dm:" + dm + "\n"
                + "cm:"+cm+ "\n"
               + "mm:" +mm + "\n" 
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



        private  async void btnvolver_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new menu());
        }

        private void btncalcular_Clicked(object sender, EventArgs e)
        {
            validar();
        }
    }
}