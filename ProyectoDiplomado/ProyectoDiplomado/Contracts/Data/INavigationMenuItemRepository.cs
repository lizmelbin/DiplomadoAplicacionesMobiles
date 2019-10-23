using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDiplomado.Contracts.Data
{
    public interface INavigationMenuItemRepository
    {
        List<Models.NavigationItems> LoadMenu();

    }
}
