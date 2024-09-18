using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Task_01
{
    internal static class DataRepository
    {
        private static List<string> _paths = new List<string>();
        public static void WriteInExcel(string path, params Human[] values)
        {
            using (var writer = new StreamWriter(path))
            {
                foreach (var item in values)
                    writer.WriteLine(item);
            }
            _paths.Add(path);
        }

        public static void WriteAsJson(params Human[] values)
        {
            foreach (var item in values)
            {
                string path = $"{item.PassportNumber}.txt";

                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine(JsonSerializer.Serialize(item));
                }
                _paths.Add(path);
            }
        }

        public static Human? ReadAsJson(string path)
        {
            _paths.Add(path);
            using (var reader = new StreamReader(path))
            {
                return JsonSerializer.Deserialize<Human>(reader.ReadToEnd());
            }
        }

        public static void Clear()
        {
            var enumer = Directory.EnumerateFiles(Directory.GetCurrentDirectory());
            foreach (var item in enumer)
            {
                switch (item.Substring(item.Length - 3))
                {
                    case "txt":
                    case "csv":
                        File.Delete(item);
                        break;
                }
            }
        }
    }
}
