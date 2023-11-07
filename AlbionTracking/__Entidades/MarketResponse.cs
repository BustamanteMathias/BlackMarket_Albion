using Newtonsoft.Json;

public class MarketResponse
{
    public string item_id { get; set; }
    public string city { get; set; }
    public int quality { get; set; }
    public long? sell_price_min { get; set; }           //ORDENES DE VENTA (LO QUE VENDE LA GENTE) MAS BAJO ** MAS IMPORTANTE, COMPRA DIRECTA
    public string sell_price_min_date { get; set; }     
    public long? sell_price_max { get; set; }           //ORDENES DE VENTA (LO QUE VENDE LA GENTE) MAS ALTO - NO IMPORTA
    public string sell_price_max_date { get; set; }     
    public long? buy_price_min { get; set; }            //ORDENES DE COMPRA (LO QUE PONEN A COMPRAR LA GENTE) - NO IMPORTA
    public string buy_price_min_date { get; set; }
    public long? buy_price_max { get; set; } = 0;       //ORDENES DE COMPRA (LO QUE PONEN A COMPRAR LA GENTE) ** ORDENES PARA PONER SI CONVIENE 
    public string buy_price_max_date { get; set; }

    public static async Task<List<MarketResponse>> GetMarketResponsesFromApi(string apiUrl)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                List<MarketResponse> marketResponses = JsonConvert.DeserializeObject<List<MarketResponse>>(json);
                return marketResponses;
            }
            return null;
        }
    }

    public override string ToString()
    {
        return $"Item ID: {item_id}, City: {city}, Quality: {quality}, " +
            $"Sell Price Min: {sell_price_min}, " +
            $"Buy Price Max: {buy_price_max}, ";
    }
}

