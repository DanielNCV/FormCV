using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FormCV
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            string nombre= paraNombre.Text;
            string apellido = paraApellido.Text;
            string email = paraEmail.Text;
            string dni = paraDNI.Text;

            await Application.Current.MainPage.Navigation.PushAsync(new Page1(nombre, apellido, email, dni));
        }
    }
}
