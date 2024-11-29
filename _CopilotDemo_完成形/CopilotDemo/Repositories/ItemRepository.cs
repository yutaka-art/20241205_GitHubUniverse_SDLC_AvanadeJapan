using System.Collections.Generic;
using System.IO;
using System.Linq;
using CopilotDemo.Models;

namespace CopilotDemo.Repositories
{
    public class ItemRepository
    {
        private readonly string _filePath = "item.csv";

        public Item? GetItemByCode(string itemCode)
        {
            if (!File.Exists(_filePath))
            {
                return null;
            }

            var lines = File.ReadAllLines(_filePath);
            foreach (var line in lines)
            {
                var columns = line.Split(',');
                if (columns[0] == itemCode)
                {
                    return new Item
                    {
                        ItemCode = columns[0],
                        ItemName = columns[1],
                        Price = decimal.Parse(columns[2])
                    };
                }
            }

            return null;
        }

        // 商品名であいまい検索
        public List<Item> GetItemsByName(string itemName)
        {
            if (!File.Exists(_filePath))
            {
                return new List<Item>();
            }

            var lines = File.ReadAllLines(_filePath);
            var items = new List<Item>();
            foreach (var line in lines)
            {
                // ヘッダー行はスキップ
                if (line.StartsWith("ItemCode"))
                {
                    continue;
                }
                var columns = line.Split(',');
                if (columns[1].Contains(itemName))
                {
                    items.Add(new Item
                    {
                        ItemCode = columns[0],
                        ItemName = columns[1],
                        Price = decimal.Parse(columns[2])
                    });
                }
            }

            return items;
        }
    }
}
