using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace __Entidades
{
    public sealed class World
    {
        public string Index { get; set; }
        public string UniqueName { get; set; }

        public static List<World>? LoadWorldFromJson(out bool status, out string result, string path)
        {
            List<World>? listWorld = null;

            try
            {
                string json = File.ReadAllText(path);
                listWorld = JsonConvert.DeserializeObject<List<World>>(json);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR Exception: {ex.Message}");
                Console.WriteLine($"ERROR Exception Stack: {ex.StackTrace}");
            }
            finally
            {
                status = false;
                result = $"Error load elements from file world.json";

                if (listWorld != null && listWorld.Count > 0)
                {
                    status = true;
                    result = $"Load world.json OK";
                }

            }

            return listWorld;
        }
    }
}
