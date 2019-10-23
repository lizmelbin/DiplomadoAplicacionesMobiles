using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ProyectoDiplomado.ViewModels
{
    public class MainPageViewModel
    {

        public ObservableCollection<Models.NavigationItems> menuItems { get; set; }
        public Contracts.Data.INavigationMenuItemRepository navigationMenuItemRepository;
        public MainPageViewModel()
        {
            menuItems = new ObservableCollection<Models.NavigationItems>();
        }

        void loadData()
        {
            var result = navigationMenuItemRepository.LoadMenu();
            if (result != null && result.Any())
            {
                foreach (var menuTemp in result)
                {
                    
                }
            }
        }

    }
}
