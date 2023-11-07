using __Entidades;
using OfficeOpenXml;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace _Testing
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            _Configuration.SetLenguage(ELocalizedNames.Español);

            //bool statusFileItems;
            //string resultFileItems;
            //bool statusFileWorld;
            //string resultFileWorld;

            ////***INFO ITEMS
            //List<Items>? listaDeItems = Items.LoadItemsFromJson(out statusFileItems, out resultFileItems, _Configuration.JSON_FILE_ITEM);
            //Console.WriteLine($"STATUS FILE ITEMS: {statusFileItems}\nRESULT FILE ITEM: {resultFileItems}");
            //if (listaDeItems != null)
            //{
            //    Console.WriteLine($"COUNT ALL ITEMS: {listaDeItems.Count}");
            //}

            //*** INFO WORLD
            //List<World>? listaDeWorld = World.LoadWorldFromJson(out statusFileWorld, out resultFileWorld, _Configuration.paths[EPaths.JSON_FILE_WORLD]);
            //Console.WriteLine($"STATUS FILE WORLD: {statusFileWorld}\nRESULT FILE WORLD: {resultFileWorld}");
            //if (listaDeWorld != null)
            //{
            //    Console.WriteLine($"COUNT ALL WORLD: {listaDeWorld.Count}");
            //}

            //DateTime horaActualUtc = DateTime.UtcNow;
            //string horaActualUtcComoCadena = horaActualUtc.ToString("yyyy-MM-ddTHH:mm:ss");
            //await Console.Out.WriteLineAsync(horaActualUtcComoCadena);

            //*** QUERY DE ITEMS MARKET
            //List<ECitysMarketID> c = new List<ECitysMarketID> { ECitysMarketID.BlackMarket, ECitysMarketID.Caerleon, ECitysMarketID.Martlock, ECitysMarketID.Lymhurst };
            //bool[] quality = new bool[5];
            //quality[0] = true;
            //quality[1] = true;
            //quality[2] = true;
            //quality[3] = true;
            //Task<List<MarketResponse>?> res = QueryManager.EXE_QueryPrices(_Configuration.paths[EPaths.WarGloves], c, quality);

            //await Task.WhenAll(res);
            //if (res.IsCompletedSuccessfully)
            //{
            //    List<MarketResponse>? marketResponses = res.Result;
            //    if (marketResponses != null)
            //    {
            //        await Console.Out.WriteLineAsync("LENGTH: " + marketResponses.Count);
            //        ModelDataGrid.ArmarDataGridView(marketResponses, listaDeItems);

            //        //foreach (var item in marketResponses)
            //        //{
            //        //    await Console.Out.WriteLineAsync(item.ToString());
            //        //}
            //    }
            //}

            //    List<ECitysMarketID> c = new List<ECitysMarketID> { ECitysMarketID.BlackMarket };
            //    bool[] quality = new bool[5];
            //    quality[0] = true;
            //    quality[1] = true;
            //    quality[2] = true;
            //    quality[3] = true;
            //    quality[4] = true;
            //    int timeSpam_h = 1;
            //    int timeSpam_d = 24;

            //    Task<List<HistoryAVG>?> res = QueryManager.EXE_QueryHistory(_Configuration.paths[EPaths.WarGloves], c, quality, timeSpam_h);

            //    await Task.WhenAll(res);
            //    if (res.IsCompletedSuccessfully)
            //    {
            //        List<HistoryAVG>? marketResponses = res.Result;
            //        if (marketResponses != null)
            //        {
            //            await Console.Out.WriteLineAsync("LENGTH: " + marketResponses.Count);
            //            //ModelDataGrid.ArmarDataGridView(marketResponses, listaDeItems);


            //            foreach (var item in marketResponses)
            //            {
            //                item.data = item.data.OrderByDescending(entry => entry.timestamp).ToList();
            //                await Console.Out.WriteLineAsync(item.ToString());
            //            }
            //        }
            //    }

            Dictionary<string, List<MarketResponse>?> dataExcel = new Dictionary<string, List<MarketResponse>?>();

            //CITYS
            List<ECitysMarketID> citys = new List<ECitysMarketID>
            {
                ECitysMarketID.BlackMarket,
                ECitysMarketID.Thetford,
                ECitysMarketID.Lymhurst,
                ECitysMarketID.Martlock,
                ECitysMarketID.Bridgewatch,
                ECitysMarketID.FortSterling,
                ECitysMarketID.Caerleon
            };

            //QUALITY
            bool[] qualitys = new bool[5];
            qualitys[0] = true;
            qualitys[1] = true;
            qualitys[2] = true;
            qualitys[3] = true;
            qualitys[4] = true;

            Console.WriteLine("Init export data...");
            foreach (EPaths path in Enum.GetValues(typeof(EPaths)))
            {
                Console.WriteLine($"Export init {path.ToString()}...");
                Task<List<MarketResponse>?> res = QueryManager.EXE_QueryPrices(_Configuration.paths[path], citys, qualitys);
                await Task.WhenAll(res);

                if (res.IsCompletedSuccessfully)
                {
                    dataExcel.Add(path.ToString(), res.Result);
                }
                Console.WriteLine($"Export finnish {path.ToString()}...");
            }
            Console.WriteLine($"Save data...");
            DataManager.SaveToExcel(dataExcel, "files_h");
            Console.WriteLine($"Save data... ");

        }
    }
}