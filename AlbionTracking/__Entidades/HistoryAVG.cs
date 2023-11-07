using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace __Entidades
{
    public class HistoryAVG
    {
        public class DataEntry
        {
            public int item_count { get; set; }
            public int avg_price { get; set; }
            public string timestamp { get; set; }
        }

        public string location { get; set; }
        public string item_id { get; set; }
        public int quality { get; set; }
        public List<DataEntry> data { get; set; }


        public static async Task<List<HistoryAVG>?> GetAVGResponsesFromApi(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    List<HistoryAVG> historyResponses = JsonConvert.DeserializeObject<List<HistoryAVG>>(json);
                    return historyResponses;
                }
                return null;
            }
        }

        public override string ToString()
        {
            string s = $"***test Item ID: {item_id}, City: {location}, Quality: {quality}\n";
            foreach (DataEntry i in data)
            {
                s += $"count:{i.item_count} -avg: {i.avg_price}-time{i.timestamp}\n";
            }

            s += "\n";
            return s;
        }
    }
}
