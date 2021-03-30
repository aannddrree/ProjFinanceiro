using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ProjFinanceiro.Dto;
using Newtonsoft.Json;

namespace ProjFinanceiro.Services
{
    public class MongoService
    {
        HttpClient httpClient = new HttpClient();
        IEnumerable<ClienteDto> lstCliente;
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5003/");

            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync("api/Cliente");

            if (response.IsSuccessStatusCode)
            {
                var clienteString = await response.Content.ReadAsStringAsync();
                lstCliente = JsonConvert.DeserializeObject<IEnumerable<ClienteDto>>(clienteString);
            }
            else{
                response.EnsureSuccessStatusCode();
            }
            
            return lstCliente;
        }
    }
}