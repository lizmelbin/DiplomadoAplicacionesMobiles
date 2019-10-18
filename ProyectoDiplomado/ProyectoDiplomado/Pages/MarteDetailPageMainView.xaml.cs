using ProyectoDiplomado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoDiplomado.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MarteDetailPageMainView : MasterDetailPage
    {
		public MarteDetailPageMainView ()
		{
			InitializeComponent ();

            menuview.menuListview.ItemSelected += MenuListview_ItemSelected;

        }

        private void MenuListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is NavigationItems item) {

                Detail = new NavigationPage((Page)Activator.CreateInstance(item.View));
                menuview.menuListview.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}