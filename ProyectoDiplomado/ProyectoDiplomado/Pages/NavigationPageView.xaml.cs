using ProyectoDiplomado.Views;
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
	public partial class NavigationPageView : ContentPage
    {
		public NavigationPageView ()
		{
			InitializeComponent ();
		}

      

       

        private async void Customer_click(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new CustomerPageView());

        }

        private async void menuItemClicked(object sender, EventArgs e)
        {
            
            if (sender == btnNavigationContact)
            {
                await this.Navigation.PushAsync(new Views.ContactView());
            }else if (sender == btnNavigationHome)
            {
                await this.Navigation.PushAsync(new Views.HomeView());
            }
            else if (sender == btnNavigationProduct)
            {
                await this.Navigation.PushAsync(new Views.ProductView());
            }
            else if (sender == btnNavigationCostomer)
            {
                await this.Navigation.PushAsync(new Views.CustomerPageView());
            }
            else if (sender == btnNavigationSettings)
            {
                await this.Navigation.PushAsync(new Views.SettingsView());
            }

        }
    }
}