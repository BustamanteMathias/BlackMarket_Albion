using Newtonsoft.Json;

namespace __Entidades
{
    public sealed class Items
    {
        public string LocalizationNameVariable { get; set; }
        public string LocalizationDescriptionVariable { get; set; }
        public Dictionary<string, string> LocalizedNames { get; set; }
        public Dictionary<string, string> LocalizedDescriptions { get; set; }
        public string Index { get; set; }
        public string UniqueName { get; set; }
        public string PathIMG { get; set; }

        public static List<Items>? LoadItemsFromJson(out bool status, out string result, string JSON_ITEM_PATH)
        {
            List<Items>? listItems = null;

            try
            {
                string jsonItems = File.ReadAllText(JSON_ITEM_PATH);
                listItems = JsonConvert.DeserializeObject<List<Items>>(jsonItems);

                foreach (EPaths pathEnum in Enum.GetValues(typeof(EPaths)))
                {
                    LoadIMG(listItems, _Configuration.paths[pathEnum]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR Exception: {ex.Message}");
                Console.WriteLine($"ERROR Exception Stack: {ex.StackTrace}");
            }
            finally
            {
                status = false;
                result = $"Error load elements from file items.json";

                if (listItems != null && listItems.Count > 0)
                {
                    status = true;
                    result = $"Load items.json OK";
                }

            }

            return listItems;
        }

        private static void LoadIMG(List<Items> listItems, string PATH_IMG)
        {
            if (listItems != null)
            {
                string[]? listIMG = DataManager.GetPathResources(PATH_IMG);
                if (listIMG != null)
                {
                    foreach (Items i in listItems)
                    {
                        foreach (string path in listIMG)
                        {
                            if (path.Contains(i.UniqueName))
                            {
                                i.PathIMG = path;
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
