using System;
using System.Collections.Generic;
using System.Text;
using ProyectoDiplomado.Contracts.Data;
using ProyectoDiplomado.Models;
using ProyectoDiplomado.Pages;

namespace ProyectoDiplomado.Services.Data
{
    public class NavigationMenuItemRepository : Contracts.Data.INavigationMenuItemRepository
    {

        System.Collections.Generic.List<Models.NavigationItems> INavigationMenuItemRepository.LoadMenu()
        {
            return  new System.Collections.Generic.List<Models.NavigationItems>
            {
                new NavigationItems{  Title="Home",  Icon="", View=typeof(Views.HomeView)},
                new NavigationItems{  Title="Contacts",  Icon="", View=typeof(Views.ContactView)},
                new NavigationItems{  Title="Products",  Icon="", View=typeof(Views.ProductView)},
                new NavigationItems{  Title="Customers",  Icon="", View=typeof(Views.CustomerPageView)},
                new NavigationItems{  Title="Settings",  Icon="", View=typeof(Views.SettingsView)}
            };

        }
    }
}
