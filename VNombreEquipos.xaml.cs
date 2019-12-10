using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dominos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VNombreEquipos : ContentPage
	{
		public VNombreEquipos ()
		{
			InitializeComponent ();
		}

        public VNombreEquipos( int totalPuntos)
        {
            InitializeComponent();
            hastaCuanto.Text = totalPuntos + "";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           // Navigation.PushAsync(new Views.VAnotaciones(  string.IsNullOrEmpty(Equipo1.Text) ? "Equipo 1 ": Equipo1.Text, string.IsNullOrEmpty(Equipo2.Text) ? "Equipo  2" : Equipo2.Text, Convert.ToInt32(hastaCuanto.Text)));
        }
        //protected override void OnElementChanged(ElementChangedEventArg<Controls.AdmobControl> e)
        //{

        //}
    }
}