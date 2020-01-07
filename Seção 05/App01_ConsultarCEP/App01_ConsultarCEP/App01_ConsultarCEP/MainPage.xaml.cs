using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico.Modelo;
using App01_ConsultarCEP.Servico;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {

            string cep = CEP.Text.Trim();

            if (isValidCEP(cep))
            {
                try
                {
                    Endereco end = ViaCEPServico.BuscarenderecoCEP(cep);
                    if(end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço :{1} {3} {0}, {2}", end.localidade, end.logradouro, end.uf, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("Erro", "Cep Não Localizado", "OK");
                    }
                    
                }
                catch (Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }

            }
            else
            {
                RESULTADO.Text = "";
            }

        }

        public bool isValidCEP(string cep)
        {
            bool Valido = true;
            
            if(cep.Length != 8)
            {
               DisplayAlert("Erro", "Cep Inválido, Deve conter 8 caracteres", "OK");
               Valido = false;
            }
          
            int NovoCEP = 0;                        
            if (!int.TryParse(cep, out NovoCEP))
            {

                DisplayAlert("Erro", "Cep Inválido, Somente Numeros são Aceitos", "OK");
                Valido = false;

            }

            return Valido;

        }
    }
}
