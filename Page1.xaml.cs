using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormCV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1(string nombre, string apellido, string email, string dni)
        {
            InitializeComponent();
            nom.Text = nombre;
            ape.Text = apellido;
            em.Text = email;
            d.Text = dni;
        }
    }
}