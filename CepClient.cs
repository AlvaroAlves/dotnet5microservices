using System.Net.Http;
using Microsoft.Extensions.Options;

namespace Dotnet5microservices
{
    class CepClient{
        private readonly HttpClient httpClient;
        private readonly ServiceSettings settings;

        public CepClient(HttpClient httpClient, IOptions<ServiceSettings> options){
            this.httpClient = httpClient;
            settings = options.Value;
        }
    }
}