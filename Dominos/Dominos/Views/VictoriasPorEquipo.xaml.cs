using Dominos.Controladores;
using Dominos.Entidades;
using Dominos.Estaticos;
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
	public partial class VictoriasPorEquipo : ContentPage
	{
		public VictoriasPorEquipo ()
		{
			InitializeComponent ();
            grid.RowDefinitions = new RowDefinitionCollection();
            grid.ColumnDefinitions = new ColumnDefinitionCollection();
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            List<KeyValuePair<string, int>> myList = EquiposController.getVictoriasPorEquipo().ToList();
            myList.Sort(
                delegate (KeyValuePair<string, int> pair1, KeyValuePair<string, int> pair2)
                {
                    return pair2.Value.CompareTo(pair1.Value);
                }
                );
            foreach (var pair in myList)
            {
                Console.WriteLine("Victorias por equipo: {0}, {1}", pair.Key, pair.Value);

                TextCell nuevaFila = new TextCell { Text = pair.Key  };
                nombreEquipos.Add(nuevaFila);
                nuevaFila = new TextCell { Text = (pair.Value) + "" };

                victoriasPorEquipo.Add(nuevaFila);
            }




        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VInicio());
        }
    }
}

/*
   var result = EquiposController.getVictoriasPorEquipo().ToDictionary(item => item, item => true);
            int i = 1;
            result.OrderBy(pair => pair.Key.Value);//.ThenBy(pair => pair.Key.Key);
            var  result1=  from pair in result
            orderby pair.Value descending
            select pair;
            foreach (var pair in result1)
            {
                Console.WriteLine("Victorias por equipo: {0}, {1}", pair.Key.Key, pair.Key.Value);
                
                TextCell nuevaFila = new TextCell { Text = pair.Key.Key };
                nombreEquipos.Add(nuevaFila);
                nuevaFila = new TextCell { Text = (pair.Key.Value) + "" };

                victoriasPorEquipo.Add(nuevaFila);
            }
*/
