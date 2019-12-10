using Android.OS;
using Dominos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Dominos.Estaticos;

namespace Dominos.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VInicio : ContentPage
	{
        
		public VInicio ()
		{
			InitializeComponent ();
           
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Entidades.Equipos e1 = getEquipo1();
                Entidades.Equipos e2 = getEquipo2();

                Navigation.PushAsync(new Views.VAnotaciones(e1, e2, Convert.ToInt32(hastaCuanto.Text)));
            }
            catch (Exception ex)
            {
                int i = 0;
            }
        }
        private Entidades.Equipos getEquipo1()
        {
            Entidades.Equipos respuesta = new Entidades.Equipos(string.IsNullOrEmpty(Equipo1.Text) ? "Equipo 1 " : Equipo1.Text);
            Comun.equiposController.insert(respuesta);
            return respuesta;

        }
        private Entidades.Equipos getEquipo2()
        {
            Entidades.Equipos respuesta = new Entidades.Equipos(string.IsNullOrEmpty(Equipo2.Text) ? "Equipo  2" : Equipo2.Text);
            Comun.equiposController.insert(respuesta);
           // DisplayAlert("","Total equipos:"+ Comun.equiposController.GetTodos().Result.Count, "OK");
            return respuesta;

        }
    }
}