using CopilotDemo.Models;
using CopilotDemo.Repositories;

namespace CopilotDemo.Services
{
    public class ItemService
    {
        private readonly ItemRepository _itemRepository;

        public ItemService()
        {
            _itemRepository = new ItemRepository();
        }

        public Item? GetItemByCode(string itemCode)
        {
            return _itemRepository.GetItemByCode(itemCode);
        }

        public List<Item> GetItemsByName(string itemName)
        {
            return _itemRepository.GetItemsByName(itemName);
        }
    }
}
