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
	public partial class ProductsPage : ContentPage
	{
        Models.ProductModel producto;

        public ProductsPage (Models.ProductModel producto)
		{
            this.producto = producto;
			InitializeComponent ();
		}
	}
}