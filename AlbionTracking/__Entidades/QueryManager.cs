using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Entidades
{
    public static class QueryManager
    {
        const string urlAPI = @"https://west.albion-online-data.com/api/v2/stats/";
        const string urlLocations = "?locations=";
        const string urlQuality = "&qualities=";
        const string historyTime_h = "&time-scale=1";
        const string historyTime_d = "&time-scale=24";

        public async static Task<List<MarketResponse>?> EXE_QueryPrices(string pathItemsFilter, List<ECitysMarketID> citys, bool[] quality)
        {
            try
            {
                List<MarketResponse> marketResponses = await MarketResponse.GetMarketResponsesFromApi(Query_CreatePrices(pathItemsFilter, "prices", citys, quality));

                if (marketResponses != null)
                {
                    return marketResponses;
                }
                else
                {
                    Console.WriteLine("Error al obtener los datos de la API.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return null;
        }

        public async static Task<List<HistoryAVG>?> EXE_QueryHistory(string pathItemsFilter, List<ECitysMarketID> citys, bool[] quality, int timespam)
        {
            try
            {
                List<HistoryAVG>? historyResponses;

                if (timespam == 1)
                {
                    string q = Query_CreatePrices(pathItemsFilter, "history", citys, quality) + historyTime_h;
                    historyResponses = await HistoryAVG.GetAVGResponsesFromApi(Query_CreateHistory(pathItemsFilter, "history", citys) + historyTime_h); //Por hora diario
                }
                else
                {
                    string q = Query_CreatePrices(pathItemsFilter, "history", citys, quality) + historyTime_d;
                    historyResponses = await HistoryAVG.GetAVGResponsesFromApi(Query_CreateHistory(pathItemsFilter, "history", citys) + historyTime_d); //Por dia
                }

                if (historyResponses != null)
                {
                    return historyResponses;
                }
                else
                {
                    Console.WriteLine("Error get data API.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return null;
        }

        private static string Query_SelectedItems(string path)
        {
            string rtn = string.Empty;
            List<string>? listFiles = DataManager.GetPathItemIMG(path);

            if (listFiles != null)
            {
                foreach (string fileID in listFiles)
                {
                    rtn += $"{Path.GetFileNameWithoutExtension(fileID)},";
                }
            }

            return rtn.Substring(0, rtn.Length - 1); ;
        }

        private static string Query_SelectedCitys(List<ECitysMarketID> citys)
        {
            string rtn = string.Empty;

            foreach (ECitysMarketID c in citys)
            {
                rtn += $"{c},";
            }

            return rtn.Substring(0, rtn.Length - 1);
        }

        private static string Query_SelectedQuality(bool[] quality)
        {
            string rtn = string.Empty;

            rtn += quality[0] ? "1," : String.Empty;
            rtn += quality[1] ? "2," : String.Empty;
            rtn += quality[2] ? "3," : String.Empty;
            rtn += quality[3] ? "4," : String.Empty;
            rtn += quality[4] ? "5," : String.Empty;

            return rtn.Substring(0, rtn.Length - 1);
        }

        private static string Query_CreatePrices(string pathItemsFilter, string selector, List<ECitysMarketID> citys, bool[] quality)
        {
            return $"{urlAPI}{selector}/{Query_SelectedItems(pathItemsFilter)}{urlLocations}{Query_SelectedCitys(citys)}{urlQuality}{Query_SelectedQuality(quality)}";
        }

        private static string Query_CreateHistory(string pathItemsFilter, string selector, List<ECitysMarketID> citys)
        {
            return $"{urlAPI}{selector}/{Query_SelectedItems(pathItemsFilter)}{urlLocations}{Query_SelectedCitys(citys)}{urlQuality}";
        }
    }
}
