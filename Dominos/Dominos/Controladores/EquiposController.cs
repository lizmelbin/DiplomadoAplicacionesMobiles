using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominos.Entidades;
using Dominos.Estaticos;
using Dominos.Interfaces;
using SQLite;
using Xamarin.Forms;

namespace Dominos.Controladores
{
    public class EquiposController : Interfaces.Controlador<Entidades.Equipos>
    {
        private static Dictionary<string, int> victoriasPorEquipo= new Dictionary<string, int>();



        public EquiposController()
        {
            
            Comun.SQLiteConnection.CreateTableAsync<Equipos>();
            

        }
        public Equipos get(Equipos entidad)
        {
            throw new NotImplementedException();
        }

        public bool insert(Equipos equipo)
        {
            try {
                var data = Comun.SQLiteConnection.Table<Equipos>();
                var d1 = data.Where(x => x.Nombre == equipo.Nombre).FirstOrDefaultAsync();
                
                if (d1.Result == null)
                {
                    Comun.SQLiteConnection.InsertAsync(equipo);
                    
                    return true;
                }
                else
                    return false;
            } catch(Exception e)
            {
                return false;
            }
             
        }
        public Task<List<Equipos>> GetTodos()
        {
            Comun.SQLiteConnection.CreateTableAsync<Equipos>();
            return   Comun.SQLiteConnection.Table<Equipos>().ToListAsync();
        }

        public static Dictionary<string, int> getVictoriasPorEquipo()
        {
            return victoriasPorEquipo;

        }

        public static void addVictoria(Equipos e)
        {
        //    bool keyFound = false;
        //    foreach (string temp in victoriasPorEquipo.Keys.ToList())
        //    {
        //        Console.WriteLine("RESULT PAIR: {0}, {1}", temp.Nombre,temp.Equals(e));
        //        if (temp.Equals(e))
        //        {
        //            keyFound = true;
        //            break;
        //        }
        //    }

            if (victoriasPorEquipo.ContainsKey(e.Nombre))
            {
                victoriasPorEquipo[e.Nombre] = victoriasPorEquipo[e.Nombre] + 1;
            }
            else
            {
                victoriasPorEquipo[e.Nombre] = 1;
            }
        }

    }
}
