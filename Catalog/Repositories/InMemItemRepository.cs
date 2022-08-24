
using System.Linq;
using Catalog.Entities;

namespace Catalog.Repositories
{   
    public class InMemItemRepository
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

    }
    
}