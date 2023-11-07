using __Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ModelDataGrid
{
    public string id { get; set; }
    public string quality { get; set; }
    public string img { get; set; }
    public object imgConvert { get; set; }
    public string name { get; set; }

    public string bm_buy_max { get; set; } //BlackMarket
    public string bm_sell_min { get; set; }
    public string bm_sell_max { get; set; }
    public string bm_buy_min { get; set; }
    public string bm_dateTime { get; set; }
    public int bm_avg_d { get; set; }
    public int bm_avg_m { get; set; }

    public string c_sell_min { get; set; }
    public string c_sell_max { get; set; }
    public string c_buy_min { get; set; }
    public string c_buy_max { get; set; }

    public string l_sell_min { get; set; }
    public string l_sell_max { get; set; }
    public string l_buy_min { get; set; }
    public string l_buy_max { get; set; }

    public string f_sell_min { get; set; }
    public string f_sell_max { get; set; }
    public string f_buy_min { get; set; }
    public string f_buy_max { get; set; }

    public string t_sell_min { get; set; }
    public string t_sell_max { get; set; }
    public string t_buy_min { get; set; }
    public string t_buy_max { get; set; }

    public string m_sell_min { get; set; }
    public string m_sell_max { get; set; }
    public string m_buy_min { get; set; }
    public string m_buy_max { get; set; }

    public string b_sell_min { get; set; }
    public string b_sell_max { get; set; }
    public string b_buy_min { get; set; }
    public string b_buy_max { get; set; }


    public ModelDataGrid(string _id)
    {
        id = _id;
    }

    public static List<ModelDataGrid> ArmarDataGridView(List<MarketResponse>? marketResponses, List<Items>? listaDeItems)
    {
        List<ModelDataGrid> listModel = new List<ModelDataGrid>();
        StringBuilder s = new StringBuilder();

        if (marketResponses != null && listaDeItems != null)
        {
            //ORDENAR POR HORARIO
            var sortedList = marketResponses.Where(item => item.buy_price_max_date != "0001-01-01T00:00:00");
            sortedList = sortedList.OrderByDescending(item => item.city == "Black Market")
                               .ThenByDescending(item => DateTime.Parse(item.buy_price_max_date))
                               .ToList();
            //foreach (var item in sortedList)
            //{
            //    Console.WriteLine("City: " + item.city + "Actualizacion: " + item.buy_price_max_date);
            //}
            //

            List<string> idsUnicos = sortedList.Select(item => item.item_id).Distinct().ToList();
            foreach (string id in idsUnicos)
            {
                listModel.Add(new ModelDataGrid(id));
            }

            foreach (ModelDataGrid model in listModel)
            {
                #region Build params NAME, IMG
                Items? e = listaDeItems.FirstOrDefault(item => item.UniqueName == model.id);
                if (e != null)
                {
                    model.name = e.LocalizedNames[_Configuration.lenguageSelected];
                    model.img = e.PathIMG;
                }
                #endregion

                #region Build params QUALITY, SELL AND BUY FOR CITY, DATE
                List<MarketResponse> itemsFiltrados = marketResponses.FindAll(item =>
                {
                    return item.item_id == model.id;
                });

                // CALCULAR CUANTAS QUALITYS TENGO SI QUIERO AGREGAR TODO
                //List<int> qualitysUnicos = itemsFiltrados.Select(item => item.quality).Distinct().ToList();

                foreach (MarketResponse item in itemsFiltrados)
                {
                    switch (item.quality)
                    {
                        case 1: model.quality = "Normal"; break;
                        case 2: model.quality = "Bueno"; break;
                        case 3: model.quality = "Notable"; break;
                        case 4: model.quality = "Sobresaliente"; break;
                        case 5: model.quality = "Obra Maestra"; break;
                    }

                    switch (item.city)
                    {
                        case "Thetford":
                            model.t_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.t_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.t_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.t_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            break;
                        case "Lymhurst":
                            model.l_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.l_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.l_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.l_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            break;
                        case "Bridgewatch":
                            model.b_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.b_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.b_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.b_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            break;
                        case "Martlock":
                            model.m_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.m_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.m_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.m_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            break;
                        case "Fort Sterling":
                            model.f_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.f_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.f_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.f_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            break;
                        case "Caerleon":
                            model.c_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.c_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.c_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.c_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            break;
                        case "Black Market":
                            model.bm_sell_min = long.Parse(item.sell_price_min.ToString()).ToString("###,###,##0");
                            model.bm_sell_max = long.Parse(item.sell_price_max.ToString()).ToString("###,###,##0");
                            model.bm_buy_min = long.Parse(item.buy_price_min.ToString()).ToString("###,###,##0");
                            model.bm_buy_max = long.Parse(item.buy_price_max.ToString()).ToString("###,###,##0");
                            model.bm_dateTime = item.buy_price_max_date.Replace("T", " ").ToString();
                            model.bm_dateTime = model.bm_dateTime.Substring(0, model.bm_dateTime.Length - 3);
                            break;
                    }
                }
                #endregion
            }
        }

        return listModel;
    }

    public static implicit operator string(ModelDataGrid data)
    {
        if (data == null)
        {
            return null;
        }

        // Genera una representación en cadena que incluye todos los atributos
        return $"id: {data.id}, quality: {data.quality}, img: {data.img}, name: {data.name}";
    }


}