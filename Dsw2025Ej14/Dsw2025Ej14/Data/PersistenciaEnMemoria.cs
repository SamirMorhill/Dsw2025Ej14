using System.Text.Json;
using Dsw2025Ej14.Api.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {
        private List<Product> _products;



        private void LoadProducts()
        {
            var json = File.ReadAllText("Data\\products.json");
            _products = JsonSerializer.Deserialize<List<Product>>(json, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            }) ?? [];
        }



    }
}
