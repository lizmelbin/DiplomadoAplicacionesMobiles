using SQLite;

namespace Dominos.Entidades
{
    [Table("Juegos")]
    public class Juegos
    {
        public Juegos()
        {
        }
        [PrimaryKey, AutoIncrement, Column("id")]
        public int Id { get; set; }
        public Equipos Equipo1 { get; set; }
        public Equipos Equipo2 { get; set; }
        public Equipos EquipoGanador { get; set; }
        public int PuntosGanador { get; set; }
        public int PuntosPerdedor { get; set; }
        public int PuntosNecesariosParaGanar{ get; set; }
        
        
    }
}