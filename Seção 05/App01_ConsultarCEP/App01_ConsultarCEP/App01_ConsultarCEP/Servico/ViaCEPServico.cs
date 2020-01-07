using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App01_ConsultarCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultarCEP.Servico
{
    public class ViaCEPServico
    {
        private static string EnderecoUrl = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarenderecoCEP(string cep)        
        {
            string NovoEnderecoURL = string.Format(EnderecoUrl, cep);

            WebClient wc = new WebClient();
            string Conteudo = wc.DownloadString(NovoEnderecoURL); // metodo sincrono(tela fica travada) 

            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo);

            if (end.cep == null)
            {
                return null;
            }
                                
            return end;
        }
    }
}
