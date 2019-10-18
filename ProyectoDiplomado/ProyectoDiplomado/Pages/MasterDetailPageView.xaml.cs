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
	public partial class MasterDetailPageView : MasterDetailPage
    {
		public MasterDetailPageView ()
		{
			InitializeComponent ();

            menuView.menuListview.ItemSelected += MenuListview_ItemSelected;
		}

        private void MenuListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is NavigationItems item)
            {

                Detail = new NavigationPage((Page)Activator.CreateInstance(item.View));
                menuView.menuListview.SelectedItem = null;
                IsPresented = false;

            }
        }
    }
}