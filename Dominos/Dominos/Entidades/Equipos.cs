using SQLite;
using System;

namespace Dominos.Entidades
{
    [Table("Equipos")]
    public class Equipos
    {
        public Equipos()
        {
        }

        public Equipos(string nombre)
        {
            this.Nombre = nombre;
        }
        [PrimaryKey]
        [MaxLength(25)]
        public string Nombre { get; set; }

        public override bool Equals(Object obj)
        {
           if(obj ==null || !(obj is Equipos) )
            {
                return false;
            }
            else
            {
                int comparacion = String.Compare((obj as Equipos).Nombre, Nombre, StringComparison.OrdinalIgnoreCase);
                return comparacion== 0; 
            }
        }
    }
}

