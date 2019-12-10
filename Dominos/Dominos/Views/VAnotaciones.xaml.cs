using Dominos.Controladores;
using Dominos.Estaticos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dominos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class VAnotaciones : ContentPage
	{

        int totalPuntosEquipo1 = 0;
        int totalPuntosEquipo2 = 0;
        int hastaCuanto = 200;
       // string nombreEquipo1;
       // string nombreEquipo2;
        Entidades.Equipos Equipo1;
        Entidades.Equipos Equipo2;
        Button bRevanchar = new Button();
        Button bNuevoJuego = new Button();
        Button bPuntuaciones = new Button();
        RowDefinition definicionFilaFinallizarJuego = new RowDefinition { Height = 50 };

        public VAnotaciones()
        {
            InitializeComponent();
        }

        public VAnotaciones(Entidades.Equipos Equipo1, Entidades.Equipos Equipo2,int hastaCuanto)
        {
          //  this.nombreEquipo1 = nombreEquipo1;
           // this.nombreEquipo2 = nombreEquipo2;
            this.hastaCuanto = hastaCuanto;
            InitializeComponent();
            lNombreEquipo1.Text = Equipo1.Nombre;
            lNombreEquipo2.Text = Equipo2.Nombre;
            this.Equipo1 = Equipo1;
            this.Equipo2 = Equipo2;
           // grid.Children.Add(new Controls.AdmobControl(),2,4);
        }


        private void agregarPunto(int puntos, TableSection dondeSeAgreganLosPuntos, bool puntosEquipo1)
        {

            Entidades.Equipos equipoGanador = puntosEquipo1 ? Equipo1 : Equipo2;
            int totalPuntos = puntos + (puntosEquipo1 ? totalPuntosEquipo1 : totalPuntosEquipo2);
            TextCell nuevaFila = new TextCell { Text = (puntos + " -- " + totalPuntos) };

            dondeSeAgreganLosPuntos.Add(nuevaFila);
            if (puntosEquipo1)
            {
                totalPuntosEquipo1 = totalPuntos;
            }
            else
            {
                totalPuntosEquipo2 = totalPuntos;
            }

            if (totalPuntos >= hastaCuanto)
            {
                this.DisplayAlert("Juego terminado", equipoGanador.Nombre + " ha ganado", "OK");
                Entidades.Juegos juego = new Entidades.Juegos();

                juego.Equipo2 = Equipo2;
                juego.Equipo1 = Equipo1;
                juego.EquipoGanador = equipoGanador;
                juego.PuntosNecesariosParaGanar = hastaCuanto;
                if (puntosEquipo1){
                    juego.PuntosGanador = totalPuntosEquipo1;
                    juego.PuntosPerdedor= totalPuntosEquipo2;

                }else {
                    juego.PuntosGanador = totalPuntosEquipo2;
                    juego.PuntosPerdedor = totalPuntosEquipo1;
                }
                try {
                    //Comun.juegosController.insert(juego);
                    EquiposController.addVictoria(equipoGanador);

                //    DisplayAlert("", "Victorias para este equipo:" + EquiposController.victoriasPorEquipo[equipoGanador], "OK");
                }catch(Exception e)
                {
                    agregarEquipo1.IsEnabled = false;

                }

                agregarEquipo1.IsEnabled = false;
                agregarEquipo2.IsEnabled = false;
                agregarEquipo1.IsVisible = false;
                agregarEquipo2.IsVisible = false;
            //1    grid.RowDefinitions.Add(definicionFilaFinallizarJuego);
                bRevanchar.Clicked += BRevanchar_Clicked;
                bRevanchar.Text = "Revancha";

            //1    grid.Children.Add(bRevanchar, 0, 4);

                bNuevoJuego.Clicked += BReiniciar_Clicked;
                bNuevoJuego.Text = "Nuevo Juego";

              //1  grid.Children.Add(bReiniciar, 2, 4);

               //1 grid.RowDefinitions.Add(definicionFilaFinallizarJuego);
                bPuntuaciones.Clicked += BRecord_Clicked;
                bPuntuaciones.Text = "Records!";

                //1grid.Children.Add(bPuntuaciones, 0, 6);
                layout.Children.Remove(bAds);
                layout.Children.Add(bRevanchar);
               
                
                layout.Children.Add(bNuevoJuego);
                layout.Children.Add(bPuntuaciones);
                layout.Children.Add(bAds);

            }



        }

        private void BRecord_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VictoriasPorEquipo());
        }
        private void BRevanchar_Clicked(object sender, EventArgs e)
        {
            totalPuntosEquipo1 = 0;
            totalPuntosEquipo2 = 0;
            puntosEquipo2.Clear();
            puntosEquipo1.Clear();
            agregarEquipo1.IsEnabled = true;
            agregarEquipo1.IsVisible = true;
            agregarEquipo2.IsVisible = true;
            agregarEquipo2.IsEnabled = true;
            grid.RowDefinitions.Remove(definicionFilaFinallizarJuego);
            //1   grid.Children.Remove(bReiniciar);
            //1   grid.Children.Remove(bRevanchar);
            layout.Children.Remove(bAds);
            layout.Children.Remove(bPuntuaciones);
            layout.Children.Remove(bRevanchar);
            layout.Children.Remove(bNuevoJuego);
            layout.Children.Add(bAds);
           
        }

        private void BReiniciar_Clicked(object sender, EventArgs e)
        {
          Navigation.PushAsync(new VInicio());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            try
            {
                String nuevoPunto = puntoAAgregarEsDelEquipo2(sender) ? agregarEquipo2.Text : agregarEquipo1.Text;
                int result = Int32.Parse(nuevoPunto);
                if (result <= 0)
                {
                    this.DisplayAlert("Error", "Debes Digitar un valor mayor que 0.\nAhora digitastes: " + result, "OK");
                }
                else
                {
                    if (puntoAAgregarEsDelEquipo2(sender))
                    { agregarEquipo2.Text = ""; }
                    else { agregarEquipo1.Text = ""; }

                    agregarPunto(result, puntoAAgregarEsDelEquipo2(sender) ? puntosEquipo2 : puntosEquipo1, !puntoAAgregarEsDelEquipo2(sender));


                }
            }
            catch (Exception exception)
            {
                this.DisplayAlert("Error", "El valor indicado no es correcto", "OK");
            }

        }

        private void tb_KeyDown(object sender, EventArgs e)
        {
            Button_Clicked(sender, e);
        }
        private bool puntoAAgregarEsDelEquipo2(Object sender)
        {
            //return sender.Equals(BagregarEquipo2) || sender.Equals(agregarEquipo2);
            return sender.Equals(agregarEquipo2);
        }
    }
}