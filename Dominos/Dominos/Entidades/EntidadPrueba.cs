using SQLite;

namespace Dominos.Entidades
{
    [Table("EntidadPrueba")]
    public  class EntidadPrueba
    {
        public EntidadPrueba()
        {
        }

        public EntidadPrueba(string nombre)
        {
            this.Nombre = nombre;
        }
        [PrimaryKey]
        [MaxLength(25)]
        public string Nombre { get; set; }

    }
}
