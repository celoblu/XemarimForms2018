using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App02_TipoPaginaXF.TipoPagina.Carousel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace App02_TipoPaginaXF
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new MainPage();
            MainPage = new IntroducaoApp();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
