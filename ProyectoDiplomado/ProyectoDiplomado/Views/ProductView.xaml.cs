﻿using ProyectoDiplomado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoDiplomado.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductView : ContentPage
    {
        public ProductView()
        {
            InitializeComponent();

            productListview.ItemSelected += ProductListview_ItemSelected;
        }

        private async void ProductListview_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is ProductModel product)
            {

               // await this.Navigation.PushAsync(new ProductDetailView(product));
                productListview.SelectedItem = null;
            }
        }
    }
}