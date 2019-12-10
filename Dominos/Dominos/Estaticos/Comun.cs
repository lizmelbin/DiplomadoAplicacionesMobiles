using Dominos.Interfaces;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Dominos.Estaticos
{
   public class Comun
    {
                
        public static SQLiteAsyncConnection SQLiteConnection= DependencyService.Get<ISQLiteInterface>().GetSQLiteConnection();

        public  static Controladores.EquiposController equiposController = new Controladores.EquiposController();
        public  static Controladores.JuegosController juegosController = new Controladores.JuegosController();
    }
}
