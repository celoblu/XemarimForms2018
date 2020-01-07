using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App02_TipoPaginaXF.TipoPagina.Carousel
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TipoPagina3 : ContentPage
	{
		public TipoPagina3 ()
		{
			InitializeComponent ();
		}
        private void MudarPagina(object sender, EventArgs args)
        {
            // APP: mainpage herda a pagina1 q esta na pasta navigation
            //App.Current.MainPage = new Navigation.Pagina1();

            // Toolbars
            //App.Current.MainPage = new NavigationPage(new Navigation.Pagina1()) { BarBackgroundColor=Color.Aquamarine};

            // Este Toolbars insere abaixo dele um menu de abas 
            //App.Current.MainPage = new NavigationPage(new Tabbed.Abas()) { BarBackgroundColor = Color.Aquamarine };

            App.Current.MainPage = new Tabbed.Abas();

        }

    }
}