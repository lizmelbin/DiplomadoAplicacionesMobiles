using System;
using System.Collections.Generic;
using System.Text;

namespace Dominos.Interfaces
{
   public interface Controlador<T> where T : class
    {
        T get(T entidad);
        bool insert(T entidad);


    }
}
