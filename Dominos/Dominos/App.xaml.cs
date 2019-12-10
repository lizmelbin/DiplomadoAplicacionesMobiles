using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Dominos
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
             //  MainPage= new Views.VAnotaciones("Liz","Lourdes",200);

            //   Views.VAnotaciones  = new Views.VAnotaciones();
         //   MainPage = new NavigationPage(new Dominos.VNombreEquipos());
             MainPage = new NavigationPage(new Views.VInicio());


        }

        protected override void OnStart()
        {
          //  Views.VAnotaciones ventana = new Views.VAnotaciones("Liz", "Lourdes");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
