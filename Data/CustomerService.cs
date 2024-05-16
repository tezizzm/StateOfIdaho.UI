using RestSharp;

namespace StateOfIdaho.UI.Data
{
    public class CustomerService
    {
        private readonly RestClientOptions options = new("https://its-invoice-apps.tapv2-proud-quokka.tapsandbox.com");

        public Task<Customer[]?> GetCustomersAsync()
        {
            var client = new RestClient(options);
            var request = new RestRequest("/customer");
            return client.GetAsync<Customer[]>(request);
        }
    }
}
