using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static Android.InputMethodServices.KeyboardView;

namespace Dominos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Views.VAnotaciones c = new Views.VAnotaciones();
        }

    }

   
}
