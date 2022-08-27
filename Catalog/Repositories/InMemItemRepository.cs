
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{
    public class InMemItemRepository : IItemRepository
    {
        private readonly List<Item> items = new()
        {
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Potion",
                Price = 50,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Shield",
                Price = 100,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Sword",
                Price = 150,
                CreatedDate = DateTimeOffset.UtcNow
            },
            new Item
            {
                Id = Guid.NewGuid(),
                Name = "Iron Armour",
                Price = 200,
                CreatedDate = DateTimeOffset.UtcNow
            }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item? GetItem(Guid id)
        {
            return items.Where(product => product.Id == id).SingleOrDefault();
        }

        public void CreateItem(Item item)
        {
            items.Add(item);
        }

        public void Create(Item item)
        {
            throw new NotImplementedException();
        }

        public void Update(Item item)
        {
            var index = items.FindIndex( findItem => findItem.Id == item.Id );
            items[index] = item;
        }

        public void DeleteItem(Guid id)
        {
            var index = items.FindIndex( foundItem => foundItem.Id == id );
            items.RemoveAt(index);
        }
    }

}