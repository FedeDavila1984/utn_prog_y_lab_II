using System;
using System.Net.Http;

namespace Entidades
{
    public delegate void DataResponse(string json, object originalSender);
    public class Descargador
    {
        public event DataResponse FinDescarga;
        private HttpClient client;

        public Descargador()
        {
            this.client = new HttpClient();
        }

        public async void Descargar(string url, object originalSender)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            // System.Threading.Thread.Sleep(3000);
            FinDescarga.Invoke(responseBody, originalSender);
        }
    }
}
