using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.IO;

namespace __Entidades
{
    public static class DataManager
    {
        public static string[]? GetPathResources(string path)
        {
            if (Directory.Exists(path))
            {
                return Directory.GetFiles(path);
            }

            return null;
        }

        public static List<string>? GetPathItemIMG(string path)
        {
            string[]? files = GetPathResources(path);

            if (files != null)
            {
                List<string> listFiles = new List<string>();
                string[] nameFiles = files.Select(Path.GetFileName).ToArray();

                foreach (string file in nameFiles)
                {
                    listFiles.Add(file);
                }

                return listFiles;
            }

            return null;
        }

        public static void SaveToExcel(Dictionary<string, List<MarketResponse>?> list, string nameFile)
        {
            FileInfo fileInfo = new FileInfo(nameFile + ".xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            foreach (string file in list.Keys)
            {
                Console.WriteLine("Save " + file);
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    var itemsWorksheet = package.Workbook.Worksheets.Add(file);
                    itemsWorksheet.Cells.LoadFromCollection(list[file], true);

                    package.Save();
                    Console.WriteLine("Terminated " + file);
                }
            }
        }
    }
}
