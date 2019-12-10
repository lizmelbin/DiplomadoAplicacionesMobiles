using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dominos.Entidades;
using Dominos.Estaticos;
using Dominos.Interfaces;
using SQLite;
using Xamarin.Forms;

namespace Dominos.Controladores
{
    public class JuegosController : Interfaces.Controlador<Entidades.Juegos>
    {
        

        public   JuegosController()
        {

            Comun.SQLiteConnection.CreateTableAsync<Juegos>().ConfigureAwait(false); ;
           // Comun.SQLiteConnection2.CreateTable<Juegos>();

        }
        public Task<List<Juegos>> GetTodos()
        {
            Comun.SQLiteConnection.CreateTableAsync<Juegos>() ;

            Task<List<Juegos>> r = Comun.SQLiteConnection.Table<Juegos>().ToListAsync();
            return r;
        }
        public Juegos get(Juegos entidad)
        {
            throw new NotImplementedException();
        }

        public bool insert(Juegos juego)
        {
            try
            {
                var data = Comun.SQLiteConnection.Table<Juegos>();
                
                    Comun.SQLiteConnection.InsertAsync(juego);
                return true;
                  
            }
            catch (Exception e)
            {
                return false;
            }
        }

        
    }
}
