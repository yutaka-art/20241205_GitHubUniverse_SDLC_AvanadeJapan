using CopilotDemo.Models;
using CopilotDemo.Services;

namespace CopilotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("商品コードを入力してください:");
            string itemCode = Console.ReadLine();

            var itemService = new ItemService();
            Item? item = itemService.GetItemByCode(itemCode);

            if (item != null)
            {
                Console.WriteLine($"商品コード: {item.ItemCode}");
                Console.WriteLine($"商品名: {item.ItemName}");
                Console.WriteLine($"金額: {item.Price}");
            }
            else
            {
                Console.WriteLine("該当する商品が見つかりませんでした。");
            }

            // 商品名であいまい検索
            Console.WriteLine("商品名を入力してください:");
            string itemName = Console.ReadLine();
            // 結果を表示
            var items = itemService.GetItemsByName(itemName);
            if (items.Count > 0)
            {
                foreach (var i in items)
                {
                    Console.WriteLine($"商品コード: {i.ItemCode}");
                    Console.WriteLine($"商品名: {i.ItemName}");
                    Console.WriteLine($"金額: {i.Price}");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("該当する商品が見つかりませんでした。");
            }

        }
    }
}
