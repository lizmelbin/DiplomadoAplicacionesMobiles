using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoDiplomado.Models
{
  public  class NavigationItems
    {
        public string Title { get; set; }
        public string Icon { get; set; }

        public Type View { get; set; }

        public NavigationItems()
        {

        }

    }
}
