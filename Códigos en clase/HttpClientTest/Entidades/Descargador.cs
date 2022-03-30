using System;
using System.Net.Http;

namespace Entidades
{
    public delegate void DataResponse(string json, object originalSender);
    public class Descargador
    {
        public event DataResponse ErrorDescarga;
        public event DataResponse FinDescarga;
        private HttpClient client;

        public Descargador()
        {
            this.client = new HttpClient();
        }

        public async void Descargar(string url, object originalSender)
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // System.Threading.Thread.Sleep(3000);
                if (this.FinDescarga is not null)
                    FinDescarga.Invoke(responseBody, originalSender);
            }
            catch (Exception ex)
            {
                if (this.ErrorDescarga is not null)
                    this.ErrorDescarga.Invoke(ex.Message, originalSender);
            }
        }
    }
}
